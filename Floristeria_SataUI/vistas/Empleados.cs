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
        int countUpdate = 0;
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

           
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEliminar);


            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void cargarEmp()
        {
            
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int documento = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Documento"].Value);

           
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (countUpdate == 1)
                {
                    MessageBox.Show("Ya hay una ventana de edición abierta.");
                    return;
                }

                countUpdate = 1; 

                actualizar_empleado actualizar = new actualizar_empleado();
                actualizar.load_txt(documento);
                actualizar.FormClosed += (s, args) =>
                {
                    countUpdate = 0;
                    cargarEmp();
                };
                actualizar.Show();
            }

           
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var result = MessageBox.Show("¿Seguro que deseas eliminar este empleado?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    query_employee query = new query_employee();
                    query.DeleteEmployee(documento.ToString());
                    cargarEmp();
                }
            }
        }
    }
}
