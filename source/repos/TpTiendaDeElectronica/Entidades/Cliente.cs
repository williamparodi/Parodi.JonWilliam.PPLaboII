using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private double dni;
        private double telefono;

        public Cliente()
        {
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
            this.dni = 0000;
            this.telefono = 0000;
        }

        public Cliente(string nombre, string apellido, double dni, double telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
        }

        public string Nombre
        {
           get { return this.nombre; }
           set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public double Dni
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public double Telefono
        {
            get { return this.telefono;}
            set { this.telefono = value; }
        }

        public bool ValidaDatosCliente(string nombre,string apellido, string dni, string telefono)
        {
            bool retorno = false;
            double dniAIngresar;
            double telefonoAIngresar;

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) 
                && double.TryParse(dni,out dniAIngresar) && double.TryParse(telefono,out telefonoAIngresar))
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.dni = dniAIngresar;
                this.telefono = telefonoAIngresar;
                retorno =  true;
            }

            return retorno;
        }
        public string MostarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre} Apellido : {this.apellido}");
            sb.AppendLine($"Dni : {this.dni} Telefono : {this.telefono}");
            return sb.ToString();
        }
    }
}
