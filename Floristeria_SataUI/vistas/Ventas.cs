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
    public partial class Ventas : Form
    {
        int count = 0;
        string documento;
        List<ItemCarrito> carrito = new List<ItemCarrito>();

        public Ventas(string doc)
        {
            InitializeComponent();
            // Cargar todos los productos al abrir el formulario
            CargarProductos();
            documento = doc;
            

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
                    Height = 310,
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
                Label cantidad_lbl = new Label
                {
                    Text = "Cantidad:" + producto.Stock.ToString(),
                    Location = new Point(10, 250),
                    Width = 180,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Regular)
                    
                };

                Button btn_carrio = new Button
                {
                    Text = "Agregar al carrito",
                    Location = new Point(10, 270),
                    Width = 180,
                    Height = 30,
                    BackColor = Color.LightGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btn_carrio.FlatAppearance.BorderSize = 0;
                btn_carrio.Click += (sender, e) =>
                {
                    
                        using (var f = new InputCantidadForm(producto.Stock))
                        {
                           
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                int cantidad = f.Cantidad;
                                int cantidad_anterior = producto.Stock;
                                producto.Stock -= cantidad;
                                cantidad_lbl.Text = "Cantidad: " + producto.Stock;

                                carrito.Add(new ItemCarrito
                                {
                                    ProductoID = producto.Id,
                                    Nombre = producto.Nombre,
                                    PrecioUnitario = producto.Precio,
                                    Cantidad = cantidad,
                                    foto = producto.Imagen,
                                    StockDisponible = cantidad_anterior




                                });
                                

                        }
                            
                        
                    }
                    
                    
                   
                };
                


                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(cantidad_lbl);    
                productPanel.Controls.Add(btn_carrio);
               

                Flow_panel.Controls.Add(productPanel);
                if(producto.Stock <= 0)
                {
                    btn_carrio.Enabled = false;
                    btn_carrio.Text = "Agotado";
                    btn_carrio.BackColor = Color.Gray;
                }
            }

            Flow_panel.Refresh();
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            CarritoVentas res = new CarritoVentas(carrito,documento);
            

            res.ShowDialog();
              
                res.FormClosed += (s, args) =>
                {
                    
                    CargarProductos();
                };
            
            
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
