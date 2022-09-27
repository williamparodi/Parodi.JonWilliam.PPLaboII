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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            Dueño dueño = new Dueño();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Usuario o contraseña erronea");

            if (txt_Usuario.Text == vendedor.GetUsuario() && txt_Password.Text == vendedor.GetPassword())
            {
                FrmVenta venta = new FrmVenta();
                venta.Show();
                this.Hide();
            }
            else if(txt_Usuario.Text == dueño.GetUsuarioDueño() && txt_Password.Text == dueño.GetPasswordDueño())
            {
                MessageBox.Show("Dueño");
            }
            else
            {
                MessageBox.Show(sb.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Usuario.Text = string.Empty;
                this.txt_Password.Text = string.Empty;
            }

           
            
        }
    }
}
