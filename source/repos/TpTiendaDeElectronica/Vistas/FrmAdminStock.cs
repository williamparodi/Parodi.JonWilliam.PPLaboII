using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAdminStock : Form
    {
        private List<Productos> listaProductos = new List<Productos>();
        private List<Productos> listaFiltrada = new List<Productos>();
        private AdminitradorStock adminitradorStock = new AdminitradorStock();
        private Productos nuevoProducto = new Productos();
        public FrmAdminStock()
        {
            InitializeComponent();
        }

        private void FrmAdminStock_Load(object sender, EventArgs e)
        {
            this.listaProductos = adminitradorStock.HarcodearLista();
            this.cmb_CategoriaStock.SelectedIndex = 0;
            this.cmb_BuscarCategoriaStock.SelectedIndex = 0;
            this.dtgv_DatagridFiltrada.DataSource = null;
        }

        private void cmb_BuscarCategoriaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminitradorStock adminitradorStock = new AdminitradorStock(this.listaProductos);
            this.listaFiltrada = adminitradorStock.FiltrarCategoria(cmb_BuscarCategoriaStock.Text);
            this.dtgv_DatagridFiltrada.DataSource = this.listaFiltrada;
        }

        private void btn_AceptarStock_Click(object sender, EventArgs e)
        {
            this.nuevoProducto = adminitradorStock.AgregarDatosAProducto(txt_NombreStock.Text, txt_CantidadStock.Text, txt_PrecioStock.Text, cmb_CategoriaStock.Text);
            this.listaProductos.Add(this.nuevoProducto);
        }


        private void btn_SalirStock_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }


        private void btn_BuscaPrecio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_BuscarPrecioMaximo.Text))
            {
                AdminitradorStock adminitradorStock = new AdminitradorStock(this.listaProductos);
                List<Productos> listaProductos = new List<Productos>();
                listaProductos = adminitradorStock.FiltrarPorPrecioMaximo(txt_BuscarPrecioMaximo.Text);
               
                this.dtgv_DatagridFiltrada.DataSource = listaProductos;
            }
        }
    }

}
