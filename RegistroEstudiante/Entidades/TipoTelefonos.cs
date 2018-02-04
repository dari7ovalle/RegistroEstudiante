using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.Entidades
{
   public  class TipoTelefonos
    {
        public int TipoId { get; set; }
        public string Celular { get; set; }
        public string  Telefono { get; set; }
        public string Descripcion { get; set; }

        public TipoTelefonos()
        {
            this.TipoId = 0;
            this.Celular = string.Empty;
            this.Telefono = string.Empty;
            this.Descripcion = string.Empty;

        }
            public TipoTelefonos (int TipoId, string Cedula, string Telefono, string descripcion )
            {
                this.TipoId = TipoId;
                this.Celular = Celular;
                this.Telefono = Telefono;
                this.Descripcion = descripcion;
            }
        

    }
}
