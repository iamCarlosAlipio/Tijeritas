using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eHorario
    {
        public int idHorario { get; set; }
        public int dia { get; set; }
        public int mes { get; set; }
        public int anio { get; set; }
        public string hora { get; set; }
        public int cantidadCuposMax { get; set; }
        public int cuposDisponibles { get; set; }
        public string estado { get; set; }
    }
}
