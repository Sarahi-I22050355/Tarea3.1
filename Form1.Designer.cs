namespace Tarea3._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNumPersonas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.textBoxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(5, 289);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(122, 20);
            this.textBoxTelefono.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Telefono";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.PaleGreen;
            this.Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Limpiar.Location = new System.Drawing.Point(151, 163);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(65, 25);
            this.Limpiar.TabIndex = 38;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(72, 29);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(65, 25);
            this.buttonAceptar.TabIndex = 37;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // textBoxNumPersonas
            // 
            this.textBoxNumPersonas.Location = new System.Drawing.Point(6, 33);
            this.textBoxNumPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumPersonas.Name = "textBoxNumPersonas";
            this.textBoxNumPersonas.Size = new System.Drawing.Size(49, 20);
            this.textBoxNumPersonas.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Por favor, ingresa un numero maximo de personas para almacenar.";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAgregar.Location = new System.Drawing.Point(151, 90);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(65, 25);
            this.buttonAgregar.TabIndex = 34;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 26);
            this.label6.TabIndex = 33;
            this.label6.Text = "Correo electronico\r\nEjemplo: correo@dominio.com";
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(6, 236);
            this.textBoxCorreoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(121, 20);
            this.textBoxCorreoElectronico.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fecha de Nacimiento (DD/MM/AAAA)";
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxFechaNacimiento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(6, 199);
            this.textBoxFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(121, 20);
            this.textBoxFechaNacimiento.TabIndex = 30;
            this.textBoxFechaNacimiento.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Por favor, ingresa los datos que se te solicitan.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // textBoxApellidoMaterno
            // 
            this.textBoxApellidoMaterno.Location = new System.Drawing.Point(6, 155);
            this.textBoxApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno";
            this.textBoxApellidoMaterno.Size = new System.Drawing.Size(121, 20);
            this.textBoxApellidoMaterno.TabIndex = 25;
            // 
            // textBoxApellidoPaterno
            // 
            this.textBoxApellidoPaterno.Location = new System.Drawing.Point(6, 115);
            this.textBoxApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno";
            this.textBoxApellidoPaterno.Size = new System.Drawing.Size(121, 20);
            this.textBoxApellidoPaterno.TabIndex = 24;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(6, 77);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // dataGridViewPersonas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPersonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonas.Location = new System.Drawing.Point(251, 33);
            this.dataGridViewPersonas.Name = "dataGridViewPersonas";
            this.dataGridViewPersonas.Size = new System.Drawing.Size(475, 299);
            this.dataGridViewPersonas.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(763, 383);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxNumPersonas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApellidoMaterno);
            this.Controls.Add(this.textBoxApellidoPaterno);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.dataGridViewPersonas);
            this.Name = "Form1";
            this.Text = "Guarda los datos de \"n\" personas en C#.";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxNumPersonas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellidoMaterno;
        private System.Windows.Forms.TextBox textBoxApellidoPaterno;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DataGridView dataGridViewPersonas;
    }
}

