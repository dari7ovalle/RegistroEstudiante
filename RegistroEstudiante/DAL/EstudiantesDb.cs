
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.DAL
{

    /// <summary>
    /// clase que maneja el contexto de la base de datos 
    /// </summary>
    class EstudiantesDb : DbContext
    {
        public DbSet<Estudiantes> Estudiante { get; set; }

        public EstudiantesDb() : base("ConStr")
        {

        }
    }
}
