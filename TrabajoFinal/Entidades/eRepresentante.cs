using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eRepresentante
    {
        public int idRepresentante { get; set; }
        public string tipoDocumento { get; set; }
        public string documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string numeroCel { get; set; }
        public DateTime fechaNacimiento { get; set; }
        
        public eRepresentante()
        {
      
        }
        public override string ToString()
        {
            return nombre + " " + apellido;
        }

    }
}
