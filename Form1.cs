using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3._1
{
    public partial class Form1 : Form
    {
        private Persona[] personas;
        public int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidarCorreoElectronico(string correoElectronico)
        {
            return correoElectronico.Contains("@") && correoElectronico.Contains(".");
        }
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today.Month < fechaNacimiento.Month || (DateTime.Today.Month == fechaNacimiento.Month && DateTime.Today.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }

        private void ActualizarTabla()
        {
            dataGridViewPersonas.Rows.Clear();
            for (int i = 0; i < index; i++)
            {
                dataGridViewPersonas.Rows.Add(personas[i].Nombre, personas[i].ApellidoPaterno, personas[i].ApellidoMaterno, personas[i].FechaNacimiento.ToString("dd/MM/yyyy"), personas[i].Edad, personas[i].CorreoElectronico, personas[i].Telefono);
            }
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Text = "";
            textBoxApellidoPaterno.Text = "";
            textBoxApellidoMaterno.Text = "";
            textBoxFechaNacimiento.Text = "";
            textBoxCorreoElectronico.Text = "";
        }


        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            dataGridViewPersonas.ColumnCount = 7;
            dataGridViewPersonas.Columns[0].Name = "Nombre";
            dataGridViewPersonas.Columns[1].Name = "Apellido Paterno";
            dataGridViewPersonas.Columns[2].Name = "Apellido Materno";
            dataGridViewPersonas.Columns[3].Name = "Fecha de Nacimiento";
            dataGridViewPersonas.Columns[4].Name = "Edad";
            dataGridViewPersonas.Columns[5].Name = "Correo Electrónico";
            dataGridViewPersonas.Columns[6].Name = "Telefono";

            int numMaxPersonas;
            bool esNumero = int.TryParse(textBoxNumPersonas.Text, out numMaxPersonas);
            if (!esNumero)
            {
                MessageBox.Show("Por favor ingrese un número válido de personas a almacenar.");
                return;
            }
            if (int.TryParse(textBoxNumPersonas.Text, out int numPersonas) && numPersonas > 0)
            {
                this.index = numPersonas;
                personas = new Persona[numMaxPersonas];
                index = 0;
                buttonAgregar.Enabled = true;
                buttonAceptar.Enabled = false;
                textBoxNumPersonas.Enabled = false;
                textBoxNombre.Enabled = true;
                textBoxApellidoPaterno.Enabled = true;
                textBoxApellidoMaterno.Enabled = true;
                textBoxFechaNacimiento.Enabled = true;
                textBoxCorreoElectronico.Enabled = true;

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de personas válido mayor a cero.");
            }
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim().ToUpper();
            string apellidoPaterno = textBoxApellidoPaterno.Text.Trim().ToUpper();
            string apellidoMaterno = textBoxApellidoMaterno.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno))
            {
                MessageBox.Show("Por favor, ingrese los datos completos de la persona.");
                return;
            }
            string telefono = textBoxTelefono.Text.Trim();
            telefono = telefono.Replace(" ", "").Replace("-", "").Replace(".", "");
            if (string.IsNullOrEmpty(telefono) || telefono.Length < 10)
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido.");
                return;
            }

            DateTime fechaNacimiento;
            if (!DateTime.TryParseExact(textBoxFechaNacimiento.Text.Trim(), "dd/MM/yyyy", null, DateTimeStyles.None, out fechaNacimiento))
            {
                MessageBox.Show("Por favor, ingrese una fecha de nacimiento válida en el formato dd/mm/yyyy.");
                return;
            }
            int edad = CalcularEdad(fechaNacimiento);

            string correoElectronico = textBoxCorreoElectronico.Text.Trim();
            if (!ValidarCorreoElectronico(correoElectronico))
            {
                MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida.");
                return;
            }

            if (index >= personas.Length)
            {
                MessageBox.Show("No se pueden agregar más personas, se ha alcanzado el límite de almacenamiento.");
                return;
            }

            Persona persona = new Persona(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correoElectronico, telefono);
            personas[index] = persona;
            index++;

            ActualizarTabla();
            LimpiarCampos();
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            // Restablecer todas las variables a sus valores iniciales
            personas = new Persona[index];


            // Borrar la tabla de datos
            dataGridViewPersonas.Rows.Clear();

            // Limpiar los campos de entrada de datos
            textBoxNombre.Clear();
            textBoxApellidoPaterno.Clear();
            textBoxApellidoMaterno.Clear();
            textBoxFechaNacimiento.Clear();
            textBoxCorreoElectronico.Clear();
            buttonAceptar.Enabled = true;
            textBoxNumPersonas.Enabled = true;
        }


    }
}
