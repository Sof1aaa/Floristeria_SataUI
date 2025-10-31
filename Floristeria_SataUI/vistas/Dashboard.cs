using Floristeria_SataUI.models;
using Floristeria_SataUI.UserControls;
using ProyectoFinal;
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
    public partial class Dashboard : Form
    {
        public Dashboard(string nombre_user, string cargo)
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
    }
}

