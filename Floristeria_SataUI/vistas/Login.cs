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
using Floristeria_SataUI.UserControls;
using Floristeria_SataUI.Controllers_query;

using System.Drawing.Drawing2D;


namespace Floristeria_SataUI
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.sataPanel1.MouseDown += Form1_MouseDown;
         
        
        }


        // Importa funciones de la API de Windows
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



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string user = txtUs.Text;
            string pass = txtPass.Text;
            security security = new security();
            security.login(int.Parse(user), pass, this);
        }

        private void cbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVer.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';

            }
        }
    }
}
