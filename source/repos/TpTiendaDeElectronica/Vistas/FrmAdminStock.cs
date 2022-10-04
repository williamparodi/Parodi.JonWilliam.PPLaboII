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
    public partial class FrmAdminStock : Form
    {
        public FrmAdminStock()
        {
            InitializeComponent();
        }

        private void FrmAdminStock_Load(object sender, EventArgs e)
        {
            this.cmb_CategoriaStock.SelectedIndex = 0;
            this.cmb_BuscarCategoriaStock.SelectedIndex = 0;
        }


    }
}
