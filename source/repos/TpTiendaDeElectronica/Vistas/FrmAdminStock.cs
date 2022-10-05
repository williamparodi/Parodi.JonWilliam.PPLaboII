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
        private List<Productos> listaFiltrada = new List<Productos>();
        private AdminitradorStock adminitradorStock = new AdminitradorStock();
        public FrmAdminStock()
        {
            InitializeComponent();
        }

        private void FrmAdminStock_Load(object sender, EventArgs e)
        {
            this.cmb_CategoriaStock.SelectedIndex = 0;
            this.cmb_BuscarCategoriaStock.SelectedIndex = 0;
            Productos listaProductos = new Productos(ECategorias.Microprocesador, "Ryzen 5", 55666, 75);
            Productos listaProductos1 = new Productos(ECategorias.Mother, "Asus", 2323, 75);
            Productos listaProductos2 = new Productos(ECategorias.Gabinete, "Terma", 65652, 75);
            Productos listaProductos3 = new Productos(ECategorias.Microprocesador, "Ryzen 5", 9874, 95);
            adminitradorStock.AgregarProductoAStock(listaProductos);
            adminitradorStock.AgregarProductoAStock(listaProductos1);
            adminitradorStock.AgregarProductoAStock(listaProductos2);
            adminitradorStock.AgregarProductoAStock(listaProductos3);
            
        }

        private void cmb_BuscarCategoriaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.listaFiltrada = adminitradorStock.FiltrarCategoria(cmb_BuscarCategoriaStock.Text);
            this.dtgv_DatagridFiltrada.DataSource = null;
            this.dtgv_DatagridFiltrada.DataSource = listaFiltrada;
        }


    }
}
