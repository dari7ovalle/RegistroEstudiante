﻿namespace RegistroEstudiante
{
    partial class PagosForm
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
            this.PagotextBoxP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ObservacionestextBoxP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NuevobuttonP = new System.Windows.Forms.Button();
            this.GuardarbuttonP = new System.Windows.Forms.Button();
            this.EliminarbuttonP = new System.Windows.Forms.Button();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.BuscarEbuttonP = new System.Windows.Forms.Button();
            this.IdEstudiantesnumericUpDownP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaTimePickerP = new System.Windows.Forms.DateTimePicker();
            this.IDnumericUpDownP = new System.Windows.Forms.NumericUpDown();
            this.BuscarbuttonP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantesnumericUpDownP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDownP)).BeginInit();
            this.SuspendLayout();
            // 
            // PagotextBoxP
            // 
            this.PagotextBoxP.Location = new System.Drawing.Point(116, 226);
            this.PagotextBoxP.Name = "PagotextBoxP";
            this.PagotextBoxP.Size = new System.Drawing.Size(232, 20);
            this.PagotextBoxP.TabIndex = 41;
            this.PagotextBoxP.TextChanged += new System.EventHandler(this.PagotextBoxP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Pago";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ObservacionestextBoxP
            // 
            this.ObservacionestextBoxP.Location = new System.Drawing.Point(116, 329);
            this.ObservacionestextBoxP.Multiline = true;
            this.ObservacionestextBoxP.Name = "ObservacionestextBoxP";
            this.ObservacionestextBoxP.Size = new System.Drawing.Size(232, 60);
            this.ObservacionestextBoxP.TabIndex = 39;
            this.ObservacionestextBoxP.TextChanged += new System.EventHandler(this.ObservacionestextBoxP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Observaciones";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // NuevobuttonP
            // 
            this.NuevobuttonP.Location = new System.Drawing.Point(45, 419);
            this.NuevobuttonP.Name = "NuevobuttonP";
            this.NuevobuttonP.Size = new System.Drawing.Size(77, 36);
            this.NuevobuttonP.TabIndex = 37;
            this.NuevobuttonP.Text = "Nuevo";
            this.NuevobuttonP.UseVisualStyleBackColor = true;
            this.NuevobuttonP.Click += new System.EventHandler(this.NuevobuttonP_Click_1);
            // 
            // GuardarbuttonP
            // 
            this.GuardarbuttonP.Location = new System.Drawing.Point(157, 419);
            this.GuardarbuttonP.Name = "GuardarbuttonP";
            this.GuardarbuttonP.Size = new System.Drawing.Size(77, 36);
            this.GuardarbuttonP.TabIndex = 36;
            this.GuardarbuttonP.Text = "Guardar";
            this.GuardarbuttonP.UseVisualStyleBackColor = true;
            this.GuardarbuttonP.Click += new System.EventHandler(this.GuardarbuttonP_Click_1);
            // 
            // EliminarbuttonP
            // 
            this.EliminarbuttonP.Location = new System.Drawing.Point(271, 419);
            this.EliminarbuttonP.Name = "EliminarbuttonP";
            this.EliminarbuttonP.Size = new System.Drawing.Size(77, 36);
            this.EliminarbuttonP.TabIndex = 35;
            this.EliminarbuttonP.Text = "Eliminar";
            this.EliminarbuttonP.UseVisualStyleBackColor = true;
            this.EliminarbuttonP.Click += new System.EventHandler(this.EliminarbuttonP_Click_1);
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(116, 281);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.ReadOnly = true;
            this.BalancetextBox.Size = new System.Drawing.Size(232, 20);
            this.BalancetextBox.TabIndex = 34;
            this.BalancetextBox.Text = "0";
            this.BalancetextBox.TextChanged += new System.EventHandler(this.BalancetextBox_TextChanged);
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(116, 182);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(232, 20);
            this.MontotextBox.TabIndex = 33;
            this.MontotextBox.TextChanged += new System.EventHandler(this.MontotextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Monto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Balance";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(258, 149);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 30;
            this.Nombrelabel.Text = "Nombre";
            this.Nombrelabel.Click += new System.EventHandler(this.Nombrelabel_Click);
            // 
            // BuscarEbuttonP
            // 
            this.BuscarEbuttonP.Location = new System.Drawing.Point(180, 133);
            this.BuscarEbuttonP.Name = "BuscarEbuttonP";
            this.BuscarEbuttonP.Size = new System.Drawing.Size(65, 35);
            this.BuscarEbuttonP.TabIndex = 29;
            this.BuscarEbuttonP.Text = "Buscar";
            this.BuscarEbuttonP.UseVisualStyleBackColor = true;
            this.BuscarEbuttonP.Click += new System.EventHandler(this.BuscarEbuttonP_Click);
            // 
            // IdEstudiantesnumericUpDownP
            // 
            this.IdEstudiantesnumericUpDownP.Location = new System.Drawing.Point(116, 142);
            this.IdEstudiantesnumericUpDownP.Name = "IdEstudiantesnumericUpDownP";
            this.IdEstudiantesnumericUpDownP.Size = new System.Drawing.Size(57, 20);
            this.IdEstudiantesnumericUpDownP.TabIndex = 28;
            this.IdEstudiantesnumericUpDownP.ValueChanged += new System.EventHandler(this.IdEstudiantesnumericUpDownP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "EstudianteID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FechaTimePickerP
            // 
            this.FechaTimePickerP.Location = new System.Drawing.Point(116, 96);
            this.FechaTimePickerP.Name = "FechaTimePickerP";
            this.FechaTimePickerP.Size = new System.Drawing.Size(232, 20);
            this.FechaTimePickerP.TabIndex = 25;
            this.FechaTimePickerP.ValueChanged += new System.EventHandler(this.FechaTimePickerP_ValueChanged);
            // 
            // IDnumericUpDownP
            // 
            this.IDnumericUpDownP.Location = new System.Drawing.Point(19, 30);
            this.IDnumericUpDownP.Name = "IDnumericUpDownP";
            this.IDnumericUpDownP.Size = new System.Drawing.Size(143, 20);
            this.IDnumericUpDownP.TabIndex = 24;
            this.IDnumericUpDownP.ValueChanged += new System.EventHandler(this.IDnumericUpDownP_ValueChanged);
            // 
            // BuscarbuttonP
            // 
            this.BuscarbuttonP.Location = new System.Drawing.Point(174, 16);
            this.BuscarbuttonP.Name = "BuscarbuttonP";
            this.BuscarbuttonP.Size = new System.Drawing.Size(77, 36);
            this.BuscarbuttonP.TabIndex = 23;
            this.BuscarbuttonP.Text = "Buscar";
            this.BuscarbuttonP.UseVisualStyleBackColor = true;
            this.BuscarbuttonP.Click += new System.EventHandler(this.BuscarbuttonP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "InscricionesID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 469);
            this.Controls.Add(this.PagotextBoxP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ObservacionestextBoxP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NuevobuttonP);
            this.Controls.Add(this.GuardarbuttonP);
            this.Controls.Add(this.EliminarbuttonP);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.BuscarEbuttonP);
            this.Controls.Add(this.IdEstudiantesnumericUpDownP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaTimePickerP);
            this.Controls.Add(this.IDnumericUpDownP);
            this.Controls.Add(this.BuscarbuttonP);
            this.Controls.Add(this.label1);
            this.Name = "PagosForm";
            this.Text = "PagosForm";
            this.Load += new System.EventHandler(this.PagosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantesnumericUpDownP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDownP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PagotextBoxP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ObservacionestextBoxP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button NuevobuttonP;
        private System.Windows.Forms.Button GuardarbuttonP;
        private System.Windows.Forms.Button EliminarbuttonP;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Button BuscarEbuttonP;
        private System.Windows.Forms.NumericUpDown IdEstudiantesnumericUpDownP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaTimePickerP;
        private System.Windows.Forms.NumericUpDown IDnumericUpDownP;
        private System.Windows.Forms.Button BuscarbuttonP;
        private System.Windows.Forms.Label label1;
    }
}