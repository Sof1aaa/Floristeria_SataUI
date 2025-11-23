using Floristeria_SataUI.Controllers_query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Floristeria_SataUI.Vistas.SubVistas
{
    public partial class Detalles_clientes : Form
    {


        public Detalles_clientes(string documento, string nombre, string apellido, string Telefono, string imagen, string Email, string Dirrecion)
        {

            InitializeComponent();
            this.sataPanel1.MouseDown += Form1_MouseDown;
            pictureBox1.ImageLocation = imagen;
            label1.Text = nombre.ToString();
            label7.Text = apellido.ToString();
            label8.Text = documento.ToString();
            label9.Text = Email.ToString();
            label10.Text = Telefono.ToString(); 
            label12.Text = Dirrecion.ToString();

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
           

           
        }

        private void sataButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
