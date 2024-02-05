using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eCita
    {
        public int codigo { get; set; }
        public int idNinio { get; set; }
        public int idHorario { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }
  
    }
}
