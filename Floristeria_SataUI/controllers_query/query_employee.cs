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
                var comando = new SqlCommand("SELECT * FROM Emoleados WHERE Cargo <> 'Desarrollador'", conexion);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employees
                        {
                            Documento = Convert.ToInt32(reader["Documento"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Cargo = reader["Cargo"].ToString(),
                            imagen = reader["Imagen"].ToString(),
                            telefono = Convert.ToInt32(reader["Telefono"])



                        });
                    }
                }
            }
            return employees;
        }

    }
}
