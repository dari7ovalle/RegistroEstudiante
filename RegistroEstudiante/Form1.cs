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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox()
        {
            //EstudiantesIdtextBox.Clear();
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            CarreratextBox.Clear();
            MatriculatextBox.Clear();
            EdadtextBox.Clear();
            DirecciontextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            EstudiantesDb db = new EstudiantesDb();

            //ponerlo en una funcion
            int estudianteId = 0;
            int.TryParse(EstudiantesIdtextBox.Text, out estudianteId);//convertir de string a entero

            Estudiantes estudiantes = new Estudiantes();

            estudiantes = db.Estudiante.Find(estudianteId);
            if (estudiantes == null)
            {
                MessageBox.Show("Estudiantes No encontada");
            }
            else
            {
                //Llenar Campos
                NombrestextBox.Text = estudiantes.Nombres;
                ApellidostextBox.Text = estudiantes.Apellidos;
                MatriculatextBox.Text = estudiantes.Matricula;
                CarreratextBox.Text = estudiantes.NombreCarrera;
                EdadtextBox.Text = estudiantes.Edad.ToString();//convertir de entero a string
                DirecciontextBox.Text = estudiantes.Direccion;

            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            EstudiantesDb db = new EstudiantesDb();

            Estudiantes estudiantes = new Estudiantes();
            int edad;
            //Funcion LlenarClase
            estudiantes.EstudianteId = 5;
            estudiantes.Nombres = NombrestextBox.Text;
            estudiantes.Apellidos = ApellidostextBox.Text;
            estudiantes.NombreCarrera = CarreratextBox.Text;
            estudiantes.Matricula = MatriculatextBox.Text;
            int.TryParse(EdadtextBox.Text, out edad);
            estudiantes.Edad = edad;
            estudiantes.Direccion = DirecciontextBox.Text;

            db.Estudiante.Add(estudiantes);
            db.SaveChanges();
            LimpiarTextBox();

            //public static bool Guardar (persona persona ){
            /// bool paso =falso;
            /// try {
            /// contexto contex =new contexto ();
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            int EstudianteId = 0;
            int Edad = 0;
            EstudiantesDb db = new EstudiantesDb();

            int.TryParse(EstudiantesIdtextBox.Text, out EstudianteId);

            var estudiante = db.Estudiante.Find(EstudianteId);

            estudiante.Nombres = NombrestextBox.Text;
            estudiante.Apellidos = ApellidostextBox.Text;
            int.TryParse(EdadtextBox.Text, out Edad);
            estudiante.Edad = Edad;
            estudiante.NombreCarrera = CarreratextBox.Text;
            estudiante.Matricula = MatriculatextBox.Text;
            estudiante.Direccion = DirecciontextBox.Text;

            db.Entry(estudiante).State = EntityState.Modified;
            db.SaveChanges();
            LimpiarTextBox();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int EstudiantesId = 0;
            EstudiantesDb db = new EstudiantesDb();

            int.TryParse(EstudiantesIdtextBox.Text, out EstudiantesId);

            var estudiante = db.Estudiante.Find(EstudiantesId);

            db.Estudiante.Remove(estudiante);
            db.SaveChanges();
            LimpiarTextBox();
        }
    }
}
