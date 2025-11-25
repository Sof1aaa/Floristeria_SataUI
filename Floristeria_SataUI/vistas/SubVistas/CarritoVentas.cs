using Floristeria_SataUI.controllers_query;
using Floristeria_SataUI.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria_SataUI.Vistas.SubVistas
{
    public partial class CarritoVentas : Form
    {
        private List<ItemCarrito> carrito;
        int count = 0;
        string documento;
        public CarritoVentas(List<ItemCarrito> items, string doc_emp)
        {
            InitializeComponent();
            carrito = items;
            cargar_combo();
            comboBox1.Enabled = false;
            documento = doc_emp;
            this.sataPanel1.MouseDown += Form1_MouseDown;


        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void CarritoVentas_Load(object sender, EventArgs e)
        {

            foreach (var item in carrito)
            {
                count++;
                flowCarrito.Controls.Add(CrearItemCarrito(item));
            }
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = carrito.Sum(x => x.Subtotal);
            label13.Text = total.ToString("C2");
        }
        private void cargar_combo()
        {

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            query_cliente cliente = new query_cliente();
            var clientes = cliente.get_all_Clientes();
            comboBox1.Items.Clear();
            foreach (var cli in clientes)
            {
                comboBox1.Items.Add(cli);

            }


        }

        private Panel CrearItemCarrito(ItemCarrito item)
        {
            Panel panel = new Panel();
            panel.Width = flowCarrito.Width - 25;
            panel.Height = 90;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;

            PictureBox pic = new PictureBox();
            pic.Width = 70;
            pic.Height = 70;
            pic.Left = 10;
            pic.Top = 10;
            pic.SizeMode = PictureBoxSizeMode.Zoom;

            if (!string.IsNullOrEmpty(item.foto))
            {
                try { pic.Image = Image.FromFile(item.foto); }
                catch { pic.Image = null; }
            }

            Label lblNombre = new Label();
            lblNombre.Text = item.Nombre;
            lblNombre.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNombre.Left = 90;
            lblNombre.Top = 10;
            lblNombre.Width = 200;

            Label lblPrecio = new Label();
            lblPrecio.Text = item.PrecioUnitario.ToString("C2");
            lblPrecio.Left = 90;
            lblPrecio.Top = 35;
            lblPrecio.Width = 120;

            NumericUpDown txtCant = new NumericUpDown();
            txtCant.Value = item.Cantidad;
            txtCant.Minimum = 1;

         
            txtCant.Maximum = item.StockDisponible;
            txtCant.Left = 220;
            txtCant.Top = 32;
            txtCant.Width = 60;

            Label lblSubtotal = new Label();
            lblSubtotal.Text = item.Subtotal.ToString("C2");
            lblSubtotal.Left = 300;
            lblSubtotal.Top = 35;
            lblSubtotal.Width = 80;

           
            txtCant.ValueChanged += (s, e) =>
            {
                int nuevaCantidad = (int)txtCant.Value;

             
                if (nuevaCantidad > item.StockDisponible)
                {
                    MessageBox.Show(
                        $"No puedes agregar más de {item.StockDisponible} unidades.",
                        "Stock insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtCant.Value = item.StockDisponible;
                    return;
                }

                item.Cantidad = nuevaCantidad;
                lblSubtotal.Text = (item.Cantidad * item.PrecioUnitario).ToString("C2");
                CalcularTotal();
            };

            Button btnEliminar = new Button();
            btnEliminar.Text = "X";
            btnEliminar.Left = panel.Width - 40;
            btnEliminar.Top = 30;
            btnEliminar.Width = 30;
            btnEliminar.Height = 30;

            btnEliminar.Click += (s, e) =>
            {
                flowCarrito.Controls.Remove(panel);
                carrito.Remove(item);
                count--;
                CalcularTotal();
            };

            panel.Controls.Add(pic);
            panel.Controls.Add(lblNombre);
            panel.Controls.Add(lblPrecio);
            panel.Controls.Add(txtCant);
            panel.Controls.Add(lblSubtotal);
            panel.Controls.Add(btnEliminar);

            return panel;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chk_regis_CheckedChanged(object sender, EventArgs e)
        {
            bool useCombo = chk_regis.Checked;

            txtNombre.Enabled = !useCombo;
            txtApellido.Enabled = !useCombo;
            txtID.Enabled = !useCombo;
            txtDireccion.Enabled = !useCombo;

            txtNombre.Texts = "";
            txtApellido.Texts = "";
            txtID.Texts = "";
            txtDireccion.Texts = "";
            comboBox1.SelectedIndex = -1;

            comboBox1.Enabled = useCombo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Clients item)
            {
                txtID.Texts = item.Documento.ToString();
                txtNombre.Texts = item.Nombre.ToString();
                txtApellido.Texts = item.Apellido.ToString();
                txtDireccion.Texts = item.Direccion.ToString();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (carrito.Count == 0)
                {
                    MessageBox.Show("El carrito está vacío.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtID.Texts))
                {
                    MessageBox.Show("Seleccione o registre un cliente antes de comprar.");
                    return;
                }

                long documentoCliente = Convert.ToInt64(txtID.Texts);
                long documentoEmpleado = Convert.ToInt64(documento);
                decimal totalVenta = carrito.Sum(x => x.Subtotal);

                query_ventas ventas = new query_ventas();

                // INSERTAR VENTA
                int idVenta = ventas.InsertarVenta(
                    documentoCliente,
                    documentoEmpleado,
                    totalVenta
                );

                if (idVenta <= 0)
                {
                    MessageBox.Show("No se pudo registrar la venta.");
                    return;
                }

               
                foreach (var item in carrito)
                {
                    ventas.InsertarDetalleVenta(
                        idVenta,
                        item.ProductoID,
                        item.Cantidad,
                        item.PrecioUnitario
                    );

                    ventas.RestarStock(item.ProductoID, item.Cantidad);
                }

        
                MessageBox.Show("¡Compra realizada con éxito!");
                carrito.Clear();
                flowCarrito.Controls.Clear();
                CalcularTotal();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
