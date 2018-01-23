using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroEstudiante.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public string Fecha { get; set; }
        public int EstudianteId { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }

        public Inscripciones()
        {
            this.InscripcionId = 0;
            this.Fecha = DateTime.Today.ToString();
            this.EstudianteId = 0;
            this.Monto = 0;
            this.Balance = 0;
        }

        public Inscripciones(int InscripcionId,string Fecha, int EstudianteId,double Monto,double Balance)
        {
            this.InscripcionId = InscripcionId;
            this.Fecha = Fecha;
            this.EstudianteId = EstudianteId;
            this.Monto = Monto;
            this.Balance = Balance;
        }
    }
}
