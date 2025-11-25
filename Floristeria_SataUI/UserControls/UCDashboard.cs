using Floristeria_SataUI.controllers_query;
using Floristeria_SataUI.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Floristeria_SataUI.UserControls
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard(string name, string charge, string id)
        {
            InitializeComponent();
            lblTitulo.Text = name;
            lblCargo.Text = charge;
            query_employee employee = new query_employee();
            var empleado = employee.get_employee_byid(Convert.ToInt64(id));
            loadtop2();
            cargargrafico();
            query_ventas ventas = new query_ventas();
            
            foreach (var item in empleado)
            {
                Profile.ImageLocation = item.imagen;
            }
            Totalventas.Text = "$" + ventas.totalVentas();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadtop2()
        {
            query_ventas ventas = new query_ventas();

            var lista = ventas.GetTop2Ventas();

           

            if (lista.Count >= 1)
            {
                lblNombre1.Text = lista[0].Nombre;
                lblCantidad1.Text = lista[0].CantidadVendida.ToString();
                lblIngresos1.Text = "$" + lista[0].Ingresos.ToString("N0");
                lblPorcentaje1.Text = lista[0].PorcentajeVentas.ToString("F2") + "%";

                if (lista[0].Foto != null && File.Exists(lista[0].Foto))
                    sataPictureBox1.Image = Image.FromFile(lista[0].Foto);
            }

          
            if (lista.Count >= 2)
            {
                lblNombre2.Text = lista[1].Nombre;
                lblCantidad2.Text = lista[1].CantidadVendida.ToString();
                lblIngresos2.Text = "$" + lista[1].Ingresos.ToString("N0");
                lblPorcentaje2.Text = lista[1].PorcentajeVentas.ToString("F2") + "%";

                if (lista[1].Foto != null && File.Exists(lista[1].Foto))
                    sataPictureBox2.Image = Image.FromFile(lista[1].Foto);
            }


        }
        private void cargargrafico()
        {
            query_ventas ventas = new query_ventas();
            var tabla = ventas.CargarGraficoProductosMasVendidos();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea("AreaPrincipal"));

            // ==========================
            // 🔹 CREAR SERIE DE BARRAS
            // ==========================
            Series serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true; // Muestra los números sobre las barras

            // ==========================
            // 🔹 CARGAR DATOS
            // ==========================
            foreach (DataRow row in tabla.Rows)
            {
                serie.Points.AddXY(row["Nombre"].ToString(), Convert.ToInt32(row["TotalVendido"]));
            }

            chart1.Series.Add(serie);
        }
    }
}
