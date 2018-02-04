using RegistroEstudiante.DAL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.BLL
{
  public   class EstudianteBLL
    {

        public static bool Guardar(Estudiantes estudiantes)
        {
            bool estado = false;
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                context.Estudiante.Add(estudiantes);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static Estudiantes Buscar(int Id)
        {
            Estudiantes estudiantes = new Estudiantes();
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                estudiantes = context.Estudiante.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return estudiantes;

        }
        public static bool Editar(Estudiantes estudiantes)
        {
            bool estado = false;

            try
            {
                EstudiantesDb context = new EstudiantesDb();
                context.Entry(estudiantes).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static bool eliminar(int Id)
        {
            Estudiantes estudiantes = null;
            bool estado = false;
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                estudiantes = context.Estudiante.Find(Id);
                context.Estudiante.Remove(estudiantes);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }
    }
}
