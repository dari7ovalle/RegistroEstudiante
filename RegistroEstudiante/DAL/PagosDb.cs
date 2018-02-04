using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.DAL
{
    class PagosDb: DbContext
    {

        public DbSet<Pagos> pago { get; set; }

        public PagosDb() : base("ConStr")
        {

        }
    }
}
