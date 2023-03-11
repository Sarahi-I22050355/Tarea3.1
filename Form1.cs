﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tarea3._1
{
    public partial class Form1 : Form
    {
        Contacto [] contactos;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// metodo para actualizar la tabla al dar boton agregar
        /// </summary>
        private void ActualizarTabla()
        {
            dataGridViewPersonas.Rows.Clear();
            for (int i = 0; i < index; i++)
            {
                string[] celdas = contactos[i].ToString().Split(' ');
                dataGridViewPersonas.Rows.Add(celdas[0], celdas[1], celdas[2], celdas[3], celdas[4], celdas[5], celdas[6]);
            }
        }
        /// <summary>
        /// Metodo para validar el correo
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool Valido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                // Utilizamos una expresión regular para validar el formato del correo electrónico
                // Si el correo electrónico tiene un formato válido, entonces la función devuelve true
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$",RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            bool esNumero = int.TryParse(nudNumPersonas.Text, out int numMaxPersonas);
            if (!esNumero)
            {
                MessageBox.Show("Por favor ingrese un número válido de personas a almacenar.");
                return;
            }
            if (int.TryParse(nudNumPersonas.Text, out int numPersonas) && numPersonas > 0)
            {
                this.index = numPersonas;
                contactos = new Contacto[numMaxPersonas];
                index = 0;
                buttonAgregar.Enabled = true;
                buttonAceptar.Enabled = false;
                nudNumPersonas.Enabled = false;
                textBoxNombre.Enabled = true;
                textBoxApellidoPaterno.Enabled = true;
                textBoxApellidoMaterno.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                textBoxCorreoElectronico.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de personas válido mayor a cero.");
            }
        }
        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellidoPaterno = textBoxApellidoPaterno.Text;
            string apellidoMaterno = textBoxApellidoMaterno.Text;
            //Validando campos completos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno))
            {
                MessageBox.Show("Por favor, ingrese los datos completos de la persona.");
                return;
            }
            string telefono = textBoxTelefono.Text.Trim();
            //Validando el numero de telefono
            if (string.IsNullOrEmpty(telefono) || telefono.Length < 10)
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido.");
                return;
            }
            string correo = textBoxCorreoElectronico.Text;
            //Validar correo
            if (!Valido(correo))
            {
                MessageBox.Show("El correo electrónico ingresado no es válido, por favor inténtalo nuevamente.");
                return;
            }
            //Alertar que se ha alcanzado el limite de almacenamiento
            if (index == contactos.Length)
            {
                MessageBox.Show("No se pueden agregar más personas, se ha alcanzado el límite de almacenamiento.");
                return;
            }
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            Contacto nuevoContacto = new Contacto
            {
                Nombre = nombre,
                ApellidoPaterno = apellidoPaterno,
                ApellidoMaterno = apellidoMaterno,
                FechaNacimiento = fechaNacimiento,
                Correo = correo,
                Telefono = telefono
            };
            contactos[index] = nuevoContacto;
            index++;
            ActualizarTabla();
            textBoxNombre.Clear();
            textBoxApellidoPaterno.Clear();
            textBoxApellidoMaterno.Clear();
            textBoxCorreoElectronico.Clear();
            textBoxTelefono.Clear(); 
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            contactos = new Contacto[index];
            dataGridViewPersonas.Rows.Clear();
            buttonAceptar.Enabled = true;
            nudNumPersonas.Value = 0;
            nudNumPersonas.Enabled= true;
            textBoxNombre.Clear();
            textBoxApellidoPaterno.Clear();
            textBoxApellidoMaterno.Clear();
            textBoxCorreoElectronico.Clear();
            textBoxTelefono.Clear();
        }
    }
}
