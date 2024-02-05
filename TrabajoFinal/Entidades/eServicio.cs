using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    public class eServicio
    {
        public int id { get; set; }
        public string nombreServicio { get; set; }
        public decimal precio { get; set; }
        public string estado { get; set; }
        public override string ToString()
        {
            return nombreServicio;
        }
       
    }
}
