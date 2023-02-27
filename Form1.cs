using System;
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
                dataGridViewPersonas.Rows.Add(contactos[i].Nombre, contactos[i].ApellidoPaterno, contactos[i].ApellidoMaterno, contactos[i].FechaNacimiento.ToString("dd/MM/yyyy"), contactos[i].Edad, contactos[i].Correo, contactos[i].Telefono);
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
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int numMaxPersonas;
            bool esNumero = int.TryParse(nudNumPersonas.Text, out numMaxPersonas);
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
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim().ToUpper();
            string apellidoPaterno = textBoxApellidoPaterno.Text.Trim().ToUpper();
            string apellidoMaterno = textBoxApellidoMaterno.Text.Trim().ToUpper();
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
            //Validar correo
            if (!Valido(textBoxCorreoElectronico.Text))
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
            string correo = textBoxCorreoElectronico.Text;
            Contacto nuevoContacto = new Contacto(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, telefono);
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
