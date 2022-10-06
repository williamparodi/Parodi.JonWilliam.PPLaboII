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
        private Vendedor vendedor = new Vendedor();
        private Dueño dueño = new Dueño();
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al apretar el boton login se fija que sea correcto el usuario y contraseña y dependiendo del usuario se
        /// despliegan diferentes forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {  
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Usuario o contraseña erronea");

            if (cmb_Usuario.Text == vendedor.GetUsuario() && txt_Password.Text == vendedor.GetPassword())
            {
                FrmVenta venta = new FrmVenta();
                venta.Show();
                this.Hide();
            }
            else if(cmb_Usuario.Text == dueño.GetUsuario() && txt_Password.Text == dueño.GetPassword())
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(sb.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmb_Usuario.Text = "Ingrese Usuario";
                this.txt_Password.Text = string.Empty;
            }

        }

        /// <summary>
        /// Obtiene los datos ingresados de pass en los text box de usuario y password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Password_Click(object sender, EventArgs e)
        {
            if(cmb_Usuario.Text == vendedor.GetUsuario())
            {
                txt_Password.Text = vendedor.GetPassword();
            }
            else if(cmb_Usuario.Text == dueño.GetUsuario())
            {
                txt_Password.Text = dueño.GetPassword();
            }
            else
            {
                this.txt_Password.Text = string.Empty;
            }
    
        }
    }
}
