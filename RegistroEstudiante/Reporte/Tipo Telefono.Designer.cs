namespace RegistroEstudiante.Entidades
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TelefonoIdtextbox = new System.Windows.Forms.MaskedTextBox();
            this.Telefonotextbox = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefonoId = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.Celulartextbox = new System.Windows.Forms.MaskedTextBox();
            this.Descripciontextbox = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TelefonoIdtextbox
            // 
            this.TelefonoIdtextbox.Location = new System.Drawing.Point(77, 26);
            this.TelefonoIdtextbox.Mask = "(999) 999-9999";
            this.TelefonoIdtextbox.Name = "TelefonoIdtextbox";
            this.TelefonoIdtextbox.Size = new System.Drawing.Size(158, 20);
            this.TelefonoIdtextbox.TabIndex = 0;
            this.TelefonoIdtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Telefonotextbox
            // 
            this.Telefonotextbox.Location = new System.Drawing.Point(77, 76);
            this.Telefonotextbox.Mask = "(999) 999-9999";
            this.Telefonotextbox.Name = "Telefonotextbox";
            this.Telefonotextbox.Size = new System.Drawing.Size(158, 20);
            this.Telefonotextbox.TabIndex = 1;
            // 
            // lbltelefonoId
            // 
            this.lbltelefonoId.AutoSize = true;
            this.lbltelefonoId.Location = new System.Drawing.Point(13, 29);
            this.lbltelefonoId.Name = "lbltelefonoId";
            this.lbltelefonoId.Size = new System.Drawing.Size(58, 13);
            this.lbltelefonoId.TabIndex = 2;
            this.lbltelefonoId.Text = "TelefonoId";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 76);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(13, 123);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 4;
            this.lblCelular.Text = "Celular";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(12, 164);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 5;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // Celulartextbox
            // 
            this.Celulartextbox.Location = new System.Drawing.Point(77, 123);
            this.Celulartextbox.Mask = "(999) 999-9999";
            this.Celulartextbox.Name = "Celulartextbox";
            this.Celulartextbox.Size = new System.Drawing.Size(145, 20);
            this.Celulartextbox.TabIndex = 6;
            // 
            // Descripciontextbox
            // 
            this.Descripciontextbox.Location = new System.Drawing.Point(77, 161);
            this.Descripciontextbox.Multiline = true;
            this.Descripciontextbox.Name = "Descripciontextbox";
            this.Descripciontextbox.Size = new System.Drawing.Size(100, 20);
            this.Descripciontextbox.TabIndex = 7;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(88, 213);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.Descripciontextbox);
            this.Controls.Add(this.Celulartextbox);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lbltelefonoId);
            this.Controls.Add(this.Telefonotextbox);
            this.Controls.Add(this.TelefonoIdtextbox);
            this.Name = "Form1";
            this.Text = "Tipo Telefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TelefonoIdtextbox;
        private System.Windows.Forms.MaskedTextBox Telefonotextbox;
        private System.Windows.Forms.Label lbltelefonoId;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.MaskedTextBox Celulartextbox;
        private System.Windows.Forms.TextBox Descripciontextbox;
        private System.Windows.Forms.Button btGuardar;
    }
}