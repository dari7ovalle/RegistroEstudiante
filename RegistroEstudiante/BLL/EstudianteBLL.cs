using RegistroEstudiante.DAL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.BLL
{
  public   class EstudianteBLL
    {

        /*
        public static DataSet GetDatoReporte ()
        {

            DataSet dataSet = new DataSet();
            EstudiantesDb context = new EstudiantesDb();
            string sql = "select * from todosEstudiantes";
                    context.Database.Sq(sql);
            dataSet = (from e in context.Estudiante select e).Cast<DataSet>();

        }*/
        public static bool ActualizarMonto(int Id, double nuevoMonto)
        {
            Estudiantes estudiantes;
            
            bool estado = false;
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                estudiantes = context.Estudiante.Find(Id);
                estudiantes.MontoEstudiante += nuevoMonto;
                context.Entry(estudiantes).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;
            }
            catch (Exception)
            {
                estado = false;
            }
            return estado;
        }

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
