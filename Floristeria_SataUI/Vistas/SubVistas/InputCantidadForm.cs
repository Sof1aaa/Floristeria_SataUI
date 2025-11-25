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
    public partial class InputCantidadForm : Form
    {
        public int Cantidad { get; set; }
        int stockDisponible;

        public InputCantidadForm(int stock)
        {
            InitializeComponent();
            this.sataPanel1.MouseDown += Form1_MouseDown;  
            stockDisponible = stock;
           
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



        private void sataButton1_Click(object sender, EventArgs e)
        {
            int valor;
            if (string.IsNullOrWhiteSpace(txtCantidad.Texts))
            {
                MessageBox.Show("Ingrese una cantidad.");
                return;
            }

            // Validar número
            if (!int.TryParse(txtCantidad.Texts, out valor))
            {
                MessageBox.Show("Ingrese solo números.");
                return;
            }

            // Validar mínimo
            if (valor <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0.");
                return;
            }

            // Validar stock
            if (valor > stockDisponible)
            {
                MessageBox.Show("La cantidad ingresada excede el stock disponible.");
                return;
            }

            Cantidad = valor;
            this.DialogResult = DialogResult.OK;
        }

        private void sataButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
