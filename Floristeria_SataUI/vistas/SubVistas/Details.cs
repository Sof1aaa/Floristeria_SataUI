using Floristeria_SataUI.Controllers_query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria_SataUI.Vistas.SubVistas
{
    public partial class Details : Form
    {
    
        public Details(int id)
        {
            InitializeComponent();
            this.sataPanel1.MouseDown += Form1_MouseDown;

            Querys_produ produ = new Querys_produ();
            produ.get_all_products_by_id(id);
            var producto = produ.get_all_products_by_id(id).FirstOrDefault();
            if (producto != null)
            {
                Name_lbl.Text = producto.Nombre;
                des_lbl.Text = producto.Descripcion;
                Price_lbl.Text = "$" + producto.Precio.ToString();
                stock_lbl.Text = producto.Stock.ToString();
                Tag_lbl.Text = producto.Categoria;

                if (!string.IsNullOrEmpty(producto.Imagen) && System.IO.File.Exists(producto.Imagen))
                {
                    pictureBox1.ImageLocation = producto.Imagen;
                }
                else
                {
                    pictureBox1.BackColor = Color.LightGray;
                }


            }









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

    }
}
