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
        
        public override void CrearUsuario()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("roberto@gmail.com");
            this.usuario = sb.ToString();
        }

        public override void CrearPassword()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("roberto1234");
            this.password = sb.ToString();
        }
        
        public override string GetUsuario()
        {
            if (this.usuario == "NN")
            {
                CrearUsuario();
            }

            return this.usuario;
        }

        public override string GetPassword()
        {
            if (this.password == "Sin contraseña")
            {
                CrearPassword();
            }

            return this.password;
        }

    }
}
