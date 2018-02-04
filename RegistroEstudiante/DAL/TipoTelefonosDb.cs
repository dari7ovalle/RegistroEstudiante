using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.DAL
{
    class TipoTelefonosDb : DbContext
    {


        public DbSet<TipoTelefonos> TipoTelefonos { get; set; }

        public TipoTelefonosDb() : base("ConStr")
        {



        }
    }
}
