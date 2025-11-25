using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Floristeria_SataUI.models;



namespace Floristeria_SataUI.Controllers_query
{
    public class Querys_produ
    {





        public void insertar_produ(string nombre, string descripcion, decimal precio, int stock, string categoria, string img)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true");
                conexion.Open();
                string consulta = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, Categoria,Imagen) VALUES (@Nombre, @Descripcion, @Precio, @Stock, @Categoria, @Img)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Stock", stock);
                comando.Parameters.AddWithValue("@Categoria", categoria);
                comando.Parameters.AddWithValue("@Img", img);
                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message);
            }
        }


        public List<product> get_all_products()
        {
            var productos = new List<product>();
            using (var conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true"))
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT * FROM Productos", conexion);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new product
                        {
                            Id = Convert.ToInt32(reader["ProductoID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Imagen = reader["Imagen"].ToString()

                        });
                    }
                }
            }
            return productos;
        }




        public void delete(int id)
        {
                
            using (var conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true"))
            {
                conexion.Open();
                var comando = new SqlCommand("DELETE FROM Productos WHERE ProductoID = @Id", conexion);
                comando.Parameters.AddWithValue("@Id", id);
                comando.ExecuteNonQuery();
            }


        }
        public List<product> get_all_products_by_id(int id)
        {
            var productos = new List<product>();
            using (var conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true"))
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT * FROM Productos WHERE ProductoID = @id", conexion);
                comando.Parameters.AddWithValue("@id", id); comando.ExecuteNonQuery();
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new product
                        {
                            Id = Convert.ToInt32(reader["ProductoID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Imagen = reader["Imagen"].ToString(),
                            Categoria = reader["Categoria"].ToString(),
                            Stock = Convert.ToInt32(reader["Stock"])
                        });
                    }
                }
            }
            return productos;
        }


        public void update(int id, string nombre, string descripcion, decimal precio, int stock, string categoria, string img)
        {
            using (var conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true"))
            {
                conexion.Open();
                var comando = new SqlCommand("UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock, Categoria = @Categoria, Imagen = @Img WHERE ProductoID = @Id", conexion);
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Stock", stock);
                comando.Parameters.AddWithValue("@Categoria", categoria);
                comando.Parameters.AddWithValue("@Img", img);
                comando.ExecuteNonQuery();
            }



        }
    }
}
