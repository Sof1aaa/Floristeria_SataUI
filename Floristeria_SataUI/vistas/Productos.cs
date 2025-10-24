using Floristeria_SataUI.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Floristeria_SataUI.Controllers_query;

namespace ProyectoFinal
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            CargarProductos();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            

          
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
          

            Querys_produ querys = new Querys_produ();
            List<product> productos = querys.get_all_products();

            

            foreach (var producto in productos)
            {
                Panel productPanel = new Panel
                {
                    Width = 200,
                    Height = 300,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };
               

                PictureBox pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top
                };
                pictureBox.Click += (s, e) =>
                {
                    //details detail = new details(producto.Id);
                   // detail.Show();
                    
                };

                if (!string.IsNullOrEmpty(producto.Imagen) && File.Exists(producto.Imagen))
                    pictureBox.ImageLocation = producto.Imagen;
                else
                    pictureBox.BackColor = Color.LightGray;

                Label nameLabel = new Label
                {
                    Text = producto.Nombre,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Height = 30
                };

                Label id = new Label
                {
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = producto.Id.ToString(),
                    
                };

                Label priceLabel = new Label
                {
                    Text = producto.Precio.ToString("C0", new CultureInfo("es-CO")),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Height = 30
                };
                Button btn_eliminar = new Button
                {
                    Text = "Eliminar",
                    Dock = DockStyle.Bottom,
                    Height = 30,
                    BackColor = Color.LightCoral,
                    ForeColor = Color.White
                };

                btn_eliminar.Click += (s, e) =>
                {
                    var result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el producto '{producto.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        querys.delete(producto.Id);
                        CargarProductos();
                    }
                };

                Button btn_actualizar = new Button
                {
                    Text = "Actualizar",
                    Dock = DockStyle.Bottom,
                    Height = 30,
                    BackColor = Color.LightGreen,
                    ForeColor = Color.White
                };
                btn_actualizar.Click += (sender, e) =>
                {
                   //actualizar actualizar = new actualizar(producto.Id);


                    //actualizar.FormClosed += (s, args) =>
                    {
                        CargarProductos(); 
                    };

                    //actualizar.Show(); 



                };




                // Agregar en orden visible
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(btn_actualizar);
                productPanel.Controls.Add(btn_eliminar);
               

                Flow_panel.Controls.Add(productPanel);
            }

            Flow_panel.Refresh();
            
        }




     

    }
}
