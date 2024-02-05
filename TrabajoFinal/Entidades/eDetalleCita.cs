using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eDetalleCita
    {
        public int idDetalle { get; set; }
        public int idCita { get; set; }
        public int idServicio { get; set; }
        public decimal subTotal { get; set; }

        //public override string ToString()
        //{
        //    return idDetalle +" "+ idCita + " "+idServicio+" " + subTotal;
        //}
    }
}
