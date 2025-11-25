using Floristeria_SataUI.models;
using Floristeria_SataUI.UserControls;
using Floristeria_SataUI.Vistas;
using Floristeria_SataUI.Vistas.SubVistas;
using ProyectoFinal;
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

namespace Floristeria_SataUI
{
    public partial class Menu : Form
    {
        string name = "";
        string charge = "";
        string document = "";
        public Menu(string nombre_user, string cargo, string doc)
        {
            InitializeComponent();
            name = nombre_user;
            charge = cargo;
            document = doc;
            this.panel3.MouseDown += Form1_MouseDown;
            this.panel2.MouseDown += Form1_MouseDown;
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

        private void btnDash_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UCDashboard(name, charge,document));
        }

        private void CargarUserControl(UserControl control)
        {
            pnlVentana.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlVentana.Controls.Add(control);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Abrirprod(new Productos());
        }


        private void Abrirprod(Form formHijo)
        {
            if (this.pnlVentana.Controls.Count > 0)
                this.pnlVentana.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.pnlVentana.Controls.Add(formHijo);
            this.pnlVentana.Tag = formHijo;
            formHijo.Show();
        }

        private void btnEmple_Click(object sender, EventArgs e)
        {
            if (charge == "Empleado")
            {
                MessageBox.Show("No tienes permisos para acceder a esta sección.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Abrirprod(new Empleados());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Lógica para el Formulario Principal (Padre)
            if (this.WindowState == FormWindowState.Normal)
            {
                // TRUCO: Le decimos al formulario que su tamaño máximo 
                // sea igual al "Área de Trabajo" (Pantalla menos barra de tareas)
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            // 2. Lógica para el formulario hijo (MDI)
            // (Esta parte la dejamos igual, ya que el hijo vive dentro del padre 
            // y no necesita el cálculo de la pantalla)
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.WindowState == FormWindowState.Normal)
                    this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                else
                    this.ActiveMdiChild.WindowState = FormWindowState.Normal;
            }
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            Abrirprod(new Clientes());
        }

        private void btnVen_Click(object sender, EventArgs e)
        {
            Abrirprod(new Ventas(document));
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            if (charge == "Empleado")
            {
                MessageBox.Show("No tienes permisos para acceder a esta sección.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Abrirprod(new Facturas());
            }
        }
    }
}


