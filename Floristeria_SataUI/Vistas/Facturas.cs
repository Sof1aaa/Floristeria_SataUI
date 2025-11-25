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
    public partial class Facturas : Form
    {
        int count = 0;
        int count2= 0;
        int countUpdate = 0;
        public Facturas()
        {
            InitializeComponent();


            CargarVentas();

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
        private void CargarVentas()
        {
            query_ventas dao = new query_ventas();

            dataGridView1.DataSource = dao.ObtenerVentasConDetalles();
        }



        private void cargarEmp()
        {
            
            query_employee query = new query_employee();
            dataGridView1.DataSource = query.get_all_Employees();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["imagen"].Visible = false;

             


        }









        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0)
                return;

          
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var result = MessageBox.Show("¿Seguro que deseas eliminar esta venta?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                   
                    int ventaID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["VentaID"].Value);

                    // Llamar al DAO
                    query_ventas dao = new query_ventas();

                    if (dao.EliminarVenta(ventaID))
                    {
                        MessageBox.Show("Venta eliminada correctamente.", "Éxito");

                       
                        CargarVentas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la venta.", "Error");
                    }
                }
            }
        }

    }
}
