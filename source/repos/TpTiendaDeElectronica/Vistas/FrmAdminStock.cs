using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vistas
{
    public partial class FrmAdminStock : Form
    {
        protected List<Productos> listaFiltrada = new List<Productos>();
        private AdminitradorStock adminitradorStock = new AdminitradorStock();
        private Productos nuevoProducto = new Productos();
        public FrmAdminStock()
        {
            InitializeComponent();
        }

        private void FrmAdminStock_Load(object sender, EventArgs e)
        {
            this.cmb_CategoriaStock.SelectedIndex = 0;
            this.cmb_BuscarCategoriaStock.SelectedIndex = 0;
            this.listaFiltrada = adminitradorStock.HarcodearLista();
            this.dtgv_DatagridFiltrada.DataSource = null;
        }

        private void cmb_BuscarCategoriaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listaFiltrada = adminitradorStock.FiltrarCategoria(cmb_BuscarCategoriaStock.Text);
            this.dtgv_DatagridFiltrada.DataSource = listaFiltrada;
        }

        private void btn_AceptarStock_Click(object sender, EventArgs e)
        {
            this.nuevoProducto = adminitradorStock.AgregarDatosAProducto(txt_NombreStock.Text, txt_CantidadStock.Text, txt_PrecioStock.Text,cmb_CategoriaStock.Text);
            adminitradorStock.AgregarProductoAStock(this.nuevoProducto);   
        }

        private void btn_SalirStock_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }
    }
}
