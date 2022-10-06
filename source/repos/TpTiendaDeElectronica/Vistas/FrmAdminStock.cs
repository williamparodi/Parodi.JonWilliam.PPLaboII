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

        /// <summary>
        /// Al cargar el form setea valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminStock_Load(object sender, EventArgs e)
        {
            this.listaProductos = adminitradorStock.HarcodearLista();///
            this.cmb_CategoriaStock.SelectedIndex = 0;
            this.cmb_BuscarCategoriaStock.SelectedIndex = 0;
            this.dtgv_DatagridFiltrada.DataSource = null;
        }

        /// <summary>
        /// Muestra la lista en el datagrid de acuerdo a la categoria elegida en el combobox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void cmb_BuscarCategoriaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminitradorStock adminitradorStock = new AdminitradorStock(this.listaProductos);
            this.listaFiltrada = adminitradorStock.FiltrarCategoria(cmb_BuscarCategoriaStock.Text);
            this.dtgv_DatagridFiltrada.DataSource = this.listaFiltrada;
        }

        /// <summary>
        /// Agrega con un producto a la lista con sus campos al tocar el boton aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AceptarStock_Click(object sender, EventArgs e)
        {
            this.nuevoProducto = adminitradorStock.AgregarDatosAProducto(txt_NombreStock.Text, txt_CantidadStock.Text, txt_PrecioStock.Text, cmb_CategoriaStock.Text);
            this.listaProductos.Add(this.nuevoProducto);
        }

        /// <summary>
        /// Sale del form actual y muestra el menu principal al tocar el boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SalirStock_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }

       
    }

}
