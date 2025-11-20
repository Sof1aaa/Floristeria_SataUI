using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria_SataUI.UserControls
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard(string name, string charge)
        {
            InitializeComponent();
            lblTitulo.Text = name;
            lblCargo.Text = charge;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
