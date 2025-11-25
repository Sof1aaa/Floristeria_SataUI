using Floristeria_SataUI.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class query_ventas
{
    private string connectionString = @"server=.\SQLEXPRESS;database=Floristeria;integrated security=true";


    public int GetStockProducto(int productoID)
    {
        int stock = 0;

        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();
            using (var comando = new SqlCommand(
                "SELECT Stock FROM Productos WHERE ProductoID = @id",
                conexion))
            {
                comando.Parameters.AddWithValue("@id", productoID);

                var result = comando.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    stock = Convert.ToInt32(result);
            }
        }

        return stock;
    }


    public void RestarStock(int productoID, int cantidad)
    {
        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();
            using (var comando = new SqlCommand(
                "UPDATE Productos SET Stock = Stock - @cant WHERE ProductoID = @id",
                conexion))
            {
                comando.Parameters.AddWithValue("@id", productoID);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.ExecuteNonQuery();
            }
        }
    }

    public void RestaurarStock(int productoID, int cantidad)
    {
        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();
            using (var comando = new SqlCommand(
                "UPDATE Productos SET Stock = Stock + @cant WHERE ProductoID = @id",
                conexion))
            {
                comando.Parameters.AddWithValue("@id", productoID);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.ExecuteNonQuery();
            }
        }
    }


    public int InsertarVenta(long clienteDoc, long empleadoDoc, decimal total)
    {
        int idVenta = 0;

        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();
            using (var comando = new SqlCommand(
                @"INSERT INTO Ventas (ClienteDocumento, EmpleadoDocumento, Fecha, Total)
                  OUTPUT INSERTED.VentaID
                  VALUES(@cli, @emp, GETDATE(), @total)",
                conexion))
            {
                comando.Parameters.AddWithValue("@cli", clienteDoc);
                comando.Parameters.AddWithValue("@emp", empleadoDoc);
                comando.Parameters.AddWithValue("@total", total);

                idVenta = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        return idVenta;
    }

 
    public void InsertarDetalleVenta(int ventaID, int productoID, int cantidad, decimal precio)
    {
        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();
            using (var comando = new SqlCommand(
                @"INSERT INTO DetalleVentas (VentaID, ProductoID, Cantidad, PrecioUnitario, Subtotal)
                  VALUES(@venta, @prod, @cant, @precio, @cant * @precio)",
                conexion))
            {
                comando.Parameters.AddWithValue("@venta", ventaID);
                comando.Parameters.AddWithValue("@prod", productoID);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@precio", precio);

                comando.ExecuteNonQuery();
            }
        }
    }

 
    public List<ProductoRanking> GetTop2Ventas()
    {
        var lista = new List<ProductoRanking>();

        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();

            string query = @"
            SELECT TOP 2
                p.Nombre,
                p.Imagen,
                SUM(ol.Cantidad) AS CantidadVendida,
                SUM(ol.Cantidad * ol.PrecioUnitario) AS Ingresos,
                (SUM(ol.Cantidad * ol.PrecioUnitario) * 100.0 / 
                    (SELECT SUM(Cantidad * PrecioUnitario) FROM DetalleVentas)
                ) AS PorcentajeVentas
            FROM Productos p
            JOIN DetalleVentas ol ON p.ProductoID = ol.ProductoID
            GROUP BY p.Nombre, p.Imagen
            ORDER BY Ingresos DESC";

            using (var cmd = new SqlCommand(query, conexion))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new ProductoRanking
                    {
                        Nombre = reader["Nombre"].ToString(),
                        Foto = reader["Imagen"].ToString(),
                        CantidadVendida = Convert.ToInt32(reader["CantidadVendida"]),
                        Ingresos = Convert.ToDecimal(reader["Ingresos"]),
                        PorcentajeVentas = Convert.ToDouble(reader["PorcentajeVentas"])
                    });
                }
            }
        }

        return lista;
    }


    public DataTable CargarGraficoProductosMasVendidos()
    {
      

        DataTable tabla = new DataTable();

       
        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();

            using (var comando = new SqlCommand(
                @"SELECT 
                 P.Nombre,
                 SUM(D.Cantidad) AS TotalVendido
              FROM DetalleVentas D
              INNER JOIN Productos P ON P.ProductoID = D.ProductoID
              GROUP BY P.Nombre
              ORDER BY TotalVendido DESC",
                conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(tabla);
            }
        }
        return tabla;
    }

    public string totalVentas()
    {
        string total = "";

        using (var conexion = new SqlConnection(connectionString))
        {
            conexion.Open();

            using (var comando = new SqlCommand(
                @"SELECT SUM(Total) AS TotalVentas FROM Ventas", conexion))
            using (var reader = comando.ExecuteReader())
            {
                if (reader.Read())  // <-- Necesario para avanzar a la primera fila
                {
                    // Maneja NULL con ternario
                    total = reader["TotalVentas"] != DBNull.Value
                        ? reader["TotalVentas"].ToString()
                        : "0";
                }
            }
        }

        return total;
    }


    public bool EliminarVenta(int ventaID)
    {
        using (SqlConnection conexion = new SqlConnection(connectionString))
        {
            conexion.Open();

            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {

                using (SqlCommand cmdDetalle = new SqlCommand(
                    "DELETE FROM DetalleVentas WHERE VentaID = @VentaID", conexion, transaccion))
                {
                    cmdDetalle.Parameters.AddWithValue("@VentaID", ventaID);
                    cmdDetalle.ExecuteNonQuery();
                }


                using (SqlCommand cmdVenta = new SqlCommand(
                    "DELETE FROM Ventas WHERE VentaID = @VentaID", conexion, transaccion))
                {
                    cmdVenta.Parameters.AddWithValue("@VentaID", ventaID);
                    cmdVenta.ExecuteNonQuery();
                }

                transaccion.Commit();
                return true;
            }
            catch
            {
                transaccion.Rollback();
                return false;
            }
        }
    }



        public DataTable ObtenerVentasConDetalles()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    V.VentaID,
                    V.ClienteDocumento,
                    V.EmpleadoDocumento,
                    V.Fecha,
                    P.ProductoID,
                    P.Nombre,
                    DV.Cantidad,
                    DV.PrecioUnitario,
                    DV.Subtotal,
                    V.Total
                FROM Ventas V
                INNER JOIN DetalleVentas DV ON V.VentaID = DV.VentaID
                INNER JOIN Productos P ON DV.ProductoID = P.ProductoID
                ORDER BY V.VentaID;
            ";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.Fill(dt);  
            }

            return dt;
        }
    }




