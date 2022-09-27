using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dueño : Vendedor
    {
        public Dueño(): base ()
        {

        }
     
        public Dueño(string usuario,string password) : base(usuario,password)
        {
            
        }
        
        private void CrearUsuarioDueño()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("roberto@gmail.com");
            this.usuario = sb.ToString();
        }

        private void CrearPasswordDueño()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("roberto1234");
            this.password = sb.ToString();
        }
        
        public string GetUsuarioDueño()
        {
            if (this.usuario == "NN")
            {
                CrearUsuarioDueño();
            }

            return this.usuario;
        }

        public string GetPasswordDueño()
        {
            if (this.password == "Sin contraseña")
            {
                CrearPasswordDueño();
            }

            return this.password;
        }

    }
}
