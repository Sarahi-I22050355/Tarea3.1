﻿using System;
using System.Windows.Forms;

namespace Tarea3._1
{
    class Persona
    {
        protected string nombre;
        protected string apellidoPaterno;
        protected string apellidoMaterno;
        protected DateTime fechaNacimiento;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value.ToUpper(); }
        }
        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value.ToUpper(); }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        /// <summary>
        /// propiedad que calcula la edad con respecto a la fecha
        /// </summary>
        public int Edad
        {
            get { return (int)((DateTime.Now - fechaNacimiento).TotalDays / 365.25); }
        }
        public Persona()
        {
            nombre = String.Empty;
            apellidoPaterno = String.Empty;
            apellidoMaterno = String.Empty;
            fechaNacimiento = DateTime.MinValue;
        }
        public Persona(string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.FechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            return nombre + " " + apellidoPaterno + " "+ apellidoMaterno +" "+ fechaNacimiento.ToString("dd/MM/yyyy") +" " + Edad;
        }
        
    }
}
