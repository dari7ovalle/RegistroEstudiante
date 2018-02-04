using RegistroEstudiante.DAL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.BLL
{
    class TipoTelefonoBLL
    {

        public static bool Guardar(TipoTelefonos tipoTelefono)
        {
            bool paso = false;

            try
            {
                TipoTelefonosDb contex = new TipoTelefonosDb();

                contex.TipoTelefonos.Add(tipoTelefono);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
    }
}