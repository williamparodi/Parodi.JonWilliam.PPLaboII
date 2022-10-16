using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAdminStock : Form
    {
        private List<Productos> listaDeProductos = new List<Productos>();
        private List<Productos> listaFiltrada = new List<Productos>();
        private AdminitradorStock adminitradorStock;
        private Productos nuevoProducto = new Productos();

        public FrmAdminStock(List<Productos> listaDeProductos)
        {
            InitializeComponent();
            this.listaDeProductos = listaDeProductos;
            this.adminitradorStock = new AdminitradorStock(listaDeProductos);
        }

        /// <summary>
        /// Al cargar el form setea valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminStock_Load(object sender, EventArgs e)
        {
            this.listaDeProductos = adminitradorStock.HarcodearLista();
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
            AdminitradorStock adminitradorStock = new AdminitradorStock(this.listaDeProductos);
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
            bool flag = false;
            
            try
            {
                ValidarDatosIngresados(txt_CantidadStock.Text, txt_PrecioStock.Text, txt_NombreStock.Text);
                foreach (Productos p in this.listaDeProductos)
                {
                    if (p.Nombre == txt_NombreStock.Text)
                    {
                        MessageBox.Show("Ya hay un producto igual se modifico precio y cantidad", "Modificacion de producto en stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        p.Cantidad = int.Parse(txt_CantidadStock.Text);
                        p.Precio = double.Parse(txt_PrecioStock.Text);
                        flag = true;
                    }
                }
                if(!flag)
                {
                    this.nuevoProducto = adminitradorStock.AgregarDatosAProducto(txt_NombreStock.Text, txt_CantidadStock.Text, txt_PrecioStock.Text, cmb_CategoriaStock.Text);
                    this.listaDeProductos.Add(this.nuevoProducto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Sale del form actual y muestra el menu principal al tocar el boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SalirStock_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(listaDeProductos);
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void CargarLista()
        {
            this.dtgv_DatagridFiltrada.DataSource = null;
            this.dtgv_DatagridFiltrada.DataSource = this.listaFiltrada;
        }

        public void ValidarDatosIngresados(string cantidad, string precio, string nombre)
        {
            try
            {
                if (string.IsNullOrEmpty(cantidad))
                {
                    throw new ExepcionesPropias("Cantidad no ingresada");
                }
                else if (string.IsNullOrEmpty(precio))
                {
                    throw new ExepcionesPropias("Precio no ingresado");
                }
                else if (string.IsNullOrEmpty(nombre))
                {
                    throw new ExepcionesPropias("Nombre no ingresado");
                }
                int.Parse(cantidad);
                double.Parse(precio);
            }
            catch (FormatException ex)
            {
                throw new ExepcionesPropias("Dato no valido", ex);
            }
            catch (Exception ex)
            {
                throw new ExepcionesPropias(ex.Message);
            }
        }

    }

}
