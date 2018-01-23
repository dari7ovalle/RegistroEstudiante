using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.DAL
{
    class InscripcionesDb : DbContext
    {
        public DbSet<Inscripciones> Inscripciones { get; set; }

        public InscripcionesDb() : base("ConStr")
        {

        }
    }
}
