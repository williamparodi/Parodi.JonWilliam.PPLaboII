using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            frmVenta.Show();
            this.Hide();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {

        }
    }
}
