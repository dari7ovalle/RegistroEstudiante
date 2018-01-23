using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.Entidades { 
    
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreCarrera { get; set; }
        public int Edad { get; set; }
        public string Matricula { get; set; }
        public string Direccion { get; set; }


        public Estudiantes()
        {
            this.EstudianteId = 0;
            this.Nombres = String.Empty;
            this.Apellidos = String.Empty;
            this.NombreCarrera = String.Empty;
            this.Matricula = String.Empty;
            this.Edad = 0;
            this.Direccion = String.Empty;
        }

        public Estudiantes(int EstudianteId, string Nombres, string Apellidos, string NombreCarrera, string Matricula, int Edad, string Direccion)
        {
            this.EstudianteId = EstudianteId;
            this.Apellidos = Apellidos;
            this.NombreCarrera = NombreCarrera;
            this.Matricula = Matricula;
            this.Edad = Edad;
            this.Direccion = Direccion;
        }

    }
}
