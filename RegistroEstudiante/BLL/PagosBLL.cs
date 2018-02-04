using RegistroEstudiante.DAL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiante.BLL
{
   public  class PagosBLL
    {

        public static bool Guardar(Pagos pago)
        {
            bool flag = false;
            if (pago != null)
            {
                try
                {
                    PagosDb context = new PagosDb();
                    context.pago.Add(pago);
                    context.SaveChanges();
                    flag = true;

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return flag;
        }

        public static Pagos Buscar(int Id)
        {
            Pagos Pagos = new Pagos();
            try
            {
                PagosDb context = new PagosDb();
                Pagos = context.pago.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return Pagos;

        }

        public static bool eliminar(int Id)
        {
            Pagos pago = null;
            bool estado = false;
            try
            {
                PagosDb context = new PagosDb();
                pago = context.pago.Find(Id);
                context.pago.Remove(pago);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> criterioBusqueda)
        {
            List<Pagos> Pagos = new List<Pagos>();
            try
            {
                PagosDb contex = new PagosDb();
                Pagos = contex.pago.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return Pagos;
        }

    }
}

