using System;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmEstadisticas : Form
    {
        
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        public FrmEstadisticas(int cantidadVentas) : this()
        {
            txt_CantidadVentas.Text = cantidadVentas.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

       
    }
}
