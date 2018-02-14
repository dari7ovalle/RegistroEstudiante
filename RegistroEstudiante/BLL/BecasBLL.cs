using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiante.DAL;
using RegistroEstudiante.Entidades;

namespace RegistroEstudiante.BLL
{
   public  class BecasBLL
    {
        public static bool Guardar(Becas becas)
        {
            bool estado = false;
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                context.Becas.Add(becas);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
        public static bool Modificar(Becas becas)
        {
            bool estado = false;

            try
            {
                EstudiantesDb context = new EstudiantesDb();
                context.Entry(becas).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static bool eliminar(int NotaId)
        {
            Becas becas = null;
            bool estado = false;
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                becas = context.Becas.Find(NotaId);
                context.Becas.Remove(becas);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }
        public static Becas Buscar(int EstudianteId)
        {
            Becas becas = new Becas();
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                becas = context.Becas.Find(EstudianteId);

            }
            catch (Exception)
            {
                throw;
            }

            return becas;

        }

        public static List<Becas> GetList(Expression<Func<Becas, bool>> criterioBusqueda)
        {
            List<Becas> becas = new List<Becas>();
            try
            {
                EstudiantesDb contex = new EstudiantesDb();
                becas = contex.Becas.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return becas;
         }
    }
}
