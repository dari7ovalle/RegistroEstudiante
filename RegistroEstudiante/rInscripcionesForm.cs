using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroEstudiante.DAL;
using RegistroEstudiante.Entidades;

namespace RegistroEstudiante
{
    public partial class rInscripcionesForm : Form
    {
        public rInscripcionesForm()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox()
        {
            InscripcionIdtextBox.Clear();
            EstudianteIdtextBox.Clear();
            MontotextBox.Clear();
            BalancetextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            InscripcionesDb db = new InscripcionesDb();

            //ponerlo en una funcion
            int InscripcionId = 0;
            int.TryParse(InscripcionIdtextBox.Text, out InscripcionId);//convertir de string a entero

            Inscripciones inscripciones = new Inscripciones();

            inscripciones = db.Inscripciones.Find(InscripcionId);
            if (inscripciones == null)
            {
                MessageBox.Show("Estudiantes No encontada");
            }
            else
            {
                //Llenar Campos
                FechadateTimePicker.Text = inscripciones.Fecha;
                EstudianteIdtextBox.Text = inscripciones.EstudianteId.ToString();
                MontotextBox.Text = inscripciones.Monto.ToString();
                BalancetextBox.Text = inscripciones.Balance.ToString();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            InscripcionesDb db = new InscripcionesDb();
            Inscripciones inscripciones = new Inscripciones();
            
            double Monto = 0, Balance = 0;
            int Id = 0;
            double.TryParse(MontotextBox.Text, out Monto);
            double.TryParse(BalancetextBox.Text, out Balance);
            int.TryParse(EstudianteIdtextBox.Text,out Id);
            inscripciones.EstudianteId = Id;
            inscripciones.Fecha = FechadateTimePicker.Text;
            inscripciones.Monto = Monto;
            inscripciones.Balance = Balance;

            db.Inscripciones.Add(inscripciones);
            db.SaveChanges();
            LimpiarTextBox();
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            int InscripcionId = 0, EstudianteId;
            double Monto = 0, Balance = 0;
            double.TryParse(MontotextBox.Text, out Monto);
            double.TryParse(BalancetextBox.Text, out Balance);
            int.TryParse(EstudianteIdtextBox.Text, out EstudianteId);
            int.TryParse(InscripcionIdtextBox.Text, out InscripcionId);

            InscripcionesDb db = new InscripcionesDb();

            var inscripcion = db.Inscripciones.Find(InscripcionId);

            inscripcion.EstudianteId = EstudianteId;
            inscripcion.Fecha = FechadateTimePicker.Text;
            inscripcion.Monto = Monto;
            inscripcion.Balance = Balance;

            db.Entry(inscripcion).State = EntityState.Modified;
            db.SaveChanges();
            LimpiarTextBox();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int InscripcionId = 0;
            InscripcionesDb db = new InscripcionesDb();

            int.TryParse(InscripcionIdtextBox.Text, out InscripcionId);

            var inscripcion = db.Inscripciones.Find(InscripcionId);

            db.Inscripciones.Remove(inscripcion);
            db.SaveChanges();
            LimpiarTextBox();
        }
    }
}
