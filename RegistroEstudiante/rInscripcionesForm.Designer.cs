namespace RegistroEstudiante
{
    partial class rInscripcionesForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EstudianteIdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.EstudiantesIdLabel = new System.Windows.Forms.Label();
            this.InscripcionIdtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Registro de Inscripciones";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(92, 122);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(222, 20);
            this.FechadateTimePicker.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Balance";
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(92, 219);
            this.BalancetextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(222, 20);
            this.BalancetextBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "EstudianteId";
            // 
            // EstudianteIdtextBox
            // 
            this.EstudianteIdtextBox.Location = new System.Drawing.Point(92, 161);
            this.EstudianteIdtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EstudianteIdtextBox.Name = "EstudianteIdtextBox";
            this.EstudianteIdtextBox.Size = new System.Drawing.Size(222, 20);
            this.EstudianteIdtextBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Monto";
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(92, 189);
            this.MontotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(222, 20);
            this.MontotextBox.TabIndex = 52;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(258, 86);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(56, 22);
            this.Buscarbutton.TabIndex = 51;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(240, 263);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(56, 19);
            this.Eliminarbutton.TabIndex = 50;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(171, 264);
            this.Modificarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(56, 19);
            this.Modificarbutton.TabIndex = 49;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(92, 264);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(56, 19);
            this.Guardarbutton.TabIndex = 48;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(33, 130);
            this.Fechalabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 46;
            this.Fechalabel.Text = "Fecha";
            // 
            // EstudiantesIdLabel
            // 
            this.EstudiantesIdLabel.AutoSize = true;
            this.EstudiantesIdLabel.Location = new System.Drawing.Point(17, 89);
            this.EstudiantesIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EstudiantesIdLabel.Name = "EstudiantesIdLabel";
            this.EstudiantesIdLabel.Size = new System.Drawing.Size(67, 13);
            this.EstudiantesIdLabel.TabIndex = 47;
            this.EstudiantesIdLabel.Text = "InscripcionId";
            // 
            // InscripcionIdtextBox
            // 
            this.InscripcionIdtextBox.Location = new System.Drawing.Point(92, 86);
            this.InscripcionIdtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.InscripcionIdtextBox.Name = "InscripcionIdtextBox";
            this.InscripcionIdtextBox.Size = new System.Drawing.Size(162, 20);
            this.InscripcionIdtextBox.TabIndex = 45;
            // 
            // rInscripcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 295);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EstudianteIdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.EstudiantesIdLabel);
            this.Controls.Add(this.InscripcionIdtextBox);
            this.Name = "rInscripcionesForm";
            this.Text = "rInscripcionesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EstudianteIdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label EstudiantesIdLabel;
        private System.Windows.Forms.TextBox InscripcionIdtextBox;
    }
}