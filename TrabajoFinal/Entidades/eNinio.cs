using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eNinio
    {
        public int idNinio { get; set; }
        public string tipoDocumento { get; set; }
        public string documento { get; set; }
        public int idRepresentante { get; set; }
        public string Nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacido { get; set; }

        //public override string ToString()
        //{
        //    return Nombre;
        //}
    }
}
