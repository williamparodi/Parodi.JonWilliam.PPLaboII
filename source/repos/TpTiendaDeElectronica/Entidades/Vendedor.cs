using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        protected string usuario;
        protected string password;
        public Vendedor()
        {
            this.usuario = "NN";
            this.password = "Sin contraseña";
        }

        public Vendedor(string usuario, string password) : this()
        {
            this.usuario = usuario;
            this.password = password;
        }

        public virtual void CrearUsuario()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("pablo@gmail.com");
            this.usuario = sb.ToString();
        }

        public virtual void CrearPassword()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("pablo1234");
            this.password = sb.ToString();
        }

        public virtual string GetUsuario()
        {
            if (this.usuario == "NN")
            {
                CrearUsuario();
            }

            return this.usuario;

        }

        public virtual string GetPassword()
        {
            if(this.password == "Sin contraseña")
            {
                CrearPassword();
            }
            return this.password;
        }




    }
}
