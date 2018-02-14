using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.Entidades
{
    public class Becas
    {
        [Key]
        public int NotaId { get; set; }
        public string Fecha { get; set; }
        public string Observaciones { get; set; }
        public int MontoaAsignatura { get; set; }
        public  int PctBeca { get; set; }
        public int Monto { get; set; }
        public int EstudianteId { get; set; }

        public Becas()
        {
            this.NotaId = 0;
            this.Fecha = " ";
            this.Observaciones = " ";
            this.MontoaAsignatura = 0;
            this.PctBeca = 0;
            this.Monto = 0;
            this.EstudianteId = 0;
        }

        public Becas( int NotaId, string Fecha, string Observaciones, int MontoAsinacion , int PctBeca , int Monto,int EstudianteId )
        {

            this.NotaId = NotaId;
            this.Fecha = Fecha;
            this.Observaciones = Observaciones;
            this.MontoaAsignatura = MontoaAsignatura;
            this.PctBeca = PctBeca;
            this.Monto = Monto;
            this.EstudianteId = EstudianteId;
        

        }




    }
}
