using System;
using System.Windows.Forms;

namespace Tarea3._1
{
    internal class Contacto : Persona
    {
        protected string correo;
        protected string telefono;

        public string Correo
        {
            get { return correo; }
            set { correo = value;}
        }
        public string Telefono
        {
            get { return telefono;}
            set { telefono = telefono = value.Replace(" ", "").Replace("-", ""); ; } 
        }
        public Contacto() : base()
        {
            correo = String.Empty;
            telefono = String.Empty;
        }
        public Contacto(string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string telefono, string correo) : base(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento)
        {
            this.Correo = correo;
            this.Telefono = telefono;  
        }
        public override string ToString()
        {
            return base.ToString()  +" " + correo  +" " + telefono;
        }
    }
}
