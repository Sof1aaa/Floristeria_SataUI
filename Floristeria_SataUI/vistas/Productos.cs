using Floristeria_SataUI.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Floristeria_SataUI.Controllers_query;
using Floristeria_SataUI.Vistas.SubVistas;

namespace ProyectoFinal
{
    public partial class Productos : Form
    {
        int count = 0;
        string documento;

        public Productos()
        {
            InitializeComponent();
            // Cargar todos los productos al abrir el formulario
            CargarProductos();
            

        }

     

        private void FiltrarProductos(string filtro)
        {
            Flow_panel.Controls.Clear();

            Querys_produ querys = new Querys_produ();
            List<product> productos = querys.get_all_products();
            List<product> productosFiltrados;

           

            if (string.IsNullOrEmpty(filtro))
            {
                
                productosFiltrados = productos;
            }
            else
            {
               
                productosFiltrados = productos
                    .Where(p =>
                        p.Nombre != null && p.Nombre.ToLower().Contains(filtro) ||
                        p.Precio.ToString().ToLower().Contains(filtro))
                    .ToList();
            }

            foreach (var producto in productosFiltrados)
            {
                Panel productPanel = new Panel
                {
                    Width = 200,
                    Height = 300,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.White
                };

                PictureBox pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10, 10),
                    Cursor = Cursors.Hand
                };

                pictureBox.Click += (s, e) =>
                {
                    try
                    {
                        Details details = new Details(producto.Id);
                        details.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al abrir detalles: " + ex.Message);
                    }
                };

                if (!string.IsNullOrEmpty(producto.Imagen) && File.Exists(producto.Imagen))
                    pictureBox.ImageLocation = producto.Imagen;
                else
                    pictureBox.BackColor = Color.LightGray;

                Label nameLabel = new Label
                {
                    Text = producto.Nombre,
                    Location = new Point(10, 200),
                    Width = 180,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                Label priceLabel = new Label
                {
                    Text = producto.Precio.ToString("C0", new CultureInfo("es-CO")),
                    Location = new Point(10, 230),
                    Width = 180,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Regular)
                };


                Button btn_actualizar = new Button
                {
                    Text = "Actualizar",
                    Location = new Point(10, 260),
                    Width = 85,
                    Height = 30,
                    BackColor = Color.LightGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btn_actualizar.FlatAppearance.BorderSize = 0;
                btn_actualizar.Click += (sender, e) =>
                {
                    Actualizar actualizar = new Actualizar(producto.Id);
                    actualizar.FormClosed += (s2, args) => CargarProductos();
                    actualizar.Show();
                };

                Button btn_eliminar = new Button
                {
                    Text = "Eliminar",
                    Location = new Point(105, 260),
                    Width = 85,
                    Height = 30,
                    BackColor = Color.LightCoral,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btn_eliminar.FlatAppearance.BorderSize = 0;
                btn_eliminar.Click += (s, e) =>
                {
                    var result = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar el producto '{producto.Nombre}'?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        querys.delete(producto.Id);
                        CargarProductos();
                    }
                };

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(btn_actualizar);
                productPanel.Controls.Add(btn_eliminar);

                Flow_panel.Controls.Add(productPanel);
            }

            Flow_panel.Refresh();
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            Regis_product res = new Regis_product();

            if (count == 0)
            {
                res.Show();
                count = 1;
                res.FormClosed += (s, args) =>
                {
                    count = 0;
                    CargarProductos();
                };
            }
            else
            {
                MessageBox.Show("Ya hay una ventana de registro abierta.");
            }
        }

        private void CargarProductos()
        {
            btnCrear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCrear.Location = new Point(this.ClientSize.Width - btnCrear.Width - 20, 20);

            Flow_panel.Location = new Point(20, 70);
            Flow_panel.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100);
            Flow_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Flow_panel.Controls.Clear();
            Flow_panel.AutoScroll = true;
            Flow_panel.WrapContents = true;
            Flow_panel.FlowDirection = FlowDirection.LeftToRight;

            
            FiltrarProductos(string.Empty);
        }

        private void sataButton1_Click(object sender, EventArgs e)
        {
            string filtro = Txt_search.Texts.Trim().ToLower();
            FiltrarProductos(filtro);
            if (string.IsNullOrEmpty(Txt_search.Texts)){
               CargarProductos();
            }
        }
    }
}
