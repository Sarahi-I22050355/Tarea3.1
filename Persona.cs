using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._1
{
    class Persona
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public int Edad
        {
            get { return (int)((DateTime.Now - FechaNacimiento).TotalDays / 365.25); }
        }
        public Persona(string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string correoElectronico, string telefono)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            FechaNacimiento = fechaNacimiento;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }
    }
}
