using Floristeria_SataUI.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria_SataUI.controllers_query
{
    public class query_employee
    {


        public List<Employees> get_all_Employees()
        {
            var employees = new List<Employees>();
            using (var conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true"))
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT * FROM Empleados WHERE Cargo <> 'Desarrollador'", conexion);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employees
                        {
                            Documento = Convert.ToInt64(reader["Documento"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Cargo = reader["Cargo"].ToString(),
                            imagen = reader["Imagen"].ToString(),
                            telefono = Convert.ToInt64(reader["Telefono"])



                        });
                    }
                }
            }
            return employees;
        }


        public List<Employees> get_employee_byid(long id)
        {
            var employees = new List<Employees>();

            using (var conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true"))
            {
                conexion.Open();

                var comando = new SqlCommand("SELECT * FROM Empleados WHERE Cargo <> 'Desarrollador' AND Documento = @doc", conexion);
                comando.Parameters.AddWithValue("@doc", id);

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employees
                        {
                            Documento = Convert.ToInt64(reader["Documento"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Cargo = reader["Cargo"].ToString(),
                            imagen = reader["Imagen"].ToString(),
                            telefono = Convert.ToInt64(reader["Telefono"])
                        });
                    }
                }
            }

            return employees;
        }


        public void insertar_employee(long documento, string nombre, string apellido, string cargo, long telefono, string contraseña, string img)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS;database=Floristeria;integrated security=true");
                conexion.Open();
                string consulta = "INSERT INTO Empleados (Documento, Nombre, Apellido, Cargo, Telefono,Contraseña, Imagen) VALUES (@Documento, @Nombre, @Apellido, @Cargo, @Telefono,@Contraseña, @Img)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Documento", documento);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Cargo", cargo);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@Img", img);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el empleado: " + ex.Message);
            }
        }

        private string connectionString = @"server=.\SQLEXPRESS;database=Floristeria;integrated security=true";

        public bool UpdateEmployee(long Documento, string Nombre, string Apellido, string Cargo, long Telefono, string imagen )
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                UPDATE Empleados SET 
                    Nombre = @Nombre,
                    Apellido = @Apellido,
                    Cargo = @Cargo,
                    Telefono = @Telefono,
                    Imagen = @Imagen
                WHERE Documento = @Documento", conn);

                cmd.Parameters.AddWithValue("@Documento", Documento);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Imagen", imagen ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteEmployee(string documento)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Empleados WHERE Documento = @Documento", conn);
                cmd.Parameters.AddWithValue("@Documento", documento);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }




}
