using Floristeria_SataUI.controllers_query;
using Floristeria_SataUI.models;
using Floristeria_SataUI.Vistas.SubVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Floristeria_SataUI.Vistas
{
    public partial class Empleados : Form
    {
        int count = 0;
        int count2= 0;
        public Empleados()
        {
            InitializeComponent();
            cargarEmp();
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEditar);

            // Botón Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEliminar);

        }


        private void cargarEmp()
        {
            // Lógica para cargar empleados
            query_employee query = new query_employee();
            dataGridView1.DataSource = query.get_all_Employees();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["imagen"].Visible = false;

             


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Regis_empleado regis_e = new Regis_empleado();
            if (count == 0)
            {
                regis_e.Show();
                count = 1;

                regis_e.FormClosed += (s, args) =>
                {
                    count = 0;
                    cargarEmp();
                };

            }
            else
            {
                MessageBox.Show("Ya hay una ventana de registro abierta.");
            }



        }
       




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (count2 == 1)
                {
                    MessageBox.Show("Ya hay una ventana de detalles abierta.");
                    return;
                }
                count2 = 1;
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];


                int documento = Convert.ToInt32(fila.Cells["Documento"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string apellido = fila.Cells["Apellido"].Value.ToString();
                string cargo = fila.Cells["Cargo"].Value.ToString();
                string imagen = fila.Cells["Imagen"].Value.ToString();
                string telefono = fila.Cells["Telefono"].Value.ToString();
            
               

                Detalles_empleados detalles = new Detalles_empleados(documento, nombre, apellido, cargo, imagen, telefono);
                detalles.Show();
                detalles.FormClosed += (s, args) =>
                {
                    count2 = 0;
                    cargarEmp();
                };


            }
        }
    }
}
