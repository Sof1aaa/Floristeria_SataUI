using Floristeria_SataUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria_SataUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UCDashboard());
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
    }
}

