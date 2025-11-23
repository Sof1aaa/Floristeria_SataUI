using Floristeria_SataUI.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Floristeria_SataUI.controllers_query
{
    public class query_cliente
    {
        private readonly string connectionString =
            @"server=.\SQLEXPRESS;database=Floristeria;integrated security=true";

        // ================================================================
        // Obtener todos los clientes
        // ================================================================
        public List<Clients> get_all_Clientes()
        {
            var clientes = new List<Clients>();

            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Clientes", conexion))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Clients
                        {
                            Documento = reader["Documento"] == DBNull.Value ? 0 : Convert.ToInt64(reader["Documento"]),
                            Nombre = reader["Nombre"]?.ToString(),
                            Apellido = reader["Apellido"]?.ToString(),
                            Telefono = reader["Telefono"] == DBNull.Value ? 0 : Convert.ToInt64(reader["Telefono"]),
                            Email = reader["Email"]?.ToString(),
                            Direccion = reader["Direccion"]?.ToString(),
                            Foto = reader["foto"] == DBNull.Value ? null : reader["foto"].ToString()
                        });
                    }
                }
            }

            return clientes;
        }


        // ================================================================
        // Obtener cliente por Documento
        // ================================================================
        public Clients get_cliente_byid(string documento)
        {
            Clients cliente = null;

            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Clientes WHERE Documento = @Documento", conexion))
                {
                    comando.Parameters.Add("@Documento", SqlDbType.BigInt).Value = Convert.ToInt64(documento);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Clients
                            {
                                Documento = Convert.ToInt64(reader["Documento"]),
                                Nombre = reader["Nombre"]?.ToString(),
                                Apellido = reader["Apellido"]?.ToString(),
                                Telefono = Convert.ToInt64(reader["Telefono"]),
                                Email = reader["Email"]?.ToString(),
                                Direccion = reader["Direccion"]?.ToString(),
                                Foto = reader["foto"] == DBNull.Value ? null : reader["foto"].ToString()
                            };
                        }
                    }
                }
            }

            return cliente;
        }


        // ================================================================
        // Insertar cliente
        // ================================================================
        public void insertar_cliente(string documento, string nombre, string apellido,
                                     string telefono, string email, string direccion, string foto)
        {
            try
            {
                using (var conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string consulta = @"
                        INSERT INTO Clientes (Documento, Nombre, Apellido, Telefono, Email, Direccion, foto) 
                        VALUES (@Documento, @Nombre, @Apellido, @Telefono, @Email, @Direccion, @Foto)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@Documento", SqlDbType.BigInt).Value = Convert.ToInt64(documento);
                        comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                        comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = apellido;
                        comando.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = Convert.ToInt64(telefono);
                        comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                        comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = direccion;
                        comando.Parameters.Add("@Foto", SqlDbType.VarChar).Value = (object)foto ?? DBNull.Value;

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente: " + ex.Message);
            }
        }


        // ================================================================
        // Actualizar cliente
        // ================================================================
        public bool UpdateCliente(string documento, string nombre, string apellido,
                                  string telefono, string email, string direccion, string foto)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    UPDATE Clientes SET 
                        Nombre = @Nombre,
                        Apellido = @Apellido,
                        Telefono = @Telefono,
                        Email = @Email,
                        Direccion = @Direccion,
                        foto = @Foto
                    WHERE Documento = @Documento";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Documento", SqlDbType.BigInt).Value = Convert.ToInt64(documento);
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                    cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = apellido;
                    cmd.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = Convert.ToInt64(telefono);
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = direccion;
                    cmd.Parameters.Add("@Foto", SqlDbType.VarChar).Value = (object)foto ?? DBNull.Value;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        // ================================================================
        // Eliminar cliente
        // ================================================================
        public bool DeleteCliente(string documento)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("DELETE FROM Clientes WHERE Documento = @Documento", conn))
                {
                    cmd.Parameters.Add("@Documento", SqlDbType.BigInt).Value = Convert.ToInt64(documento);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
