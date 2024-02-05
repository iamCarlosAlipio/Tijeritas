using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class nDetalleCita
    {
        dDetalleCita detallecitad;

        public nDetalleCita()
        {
            detallecitad = new dDetalleCita();
        }
        public string RegistrarDetalleCita(int idservicio, decimal subtotal, int idcita)
        { 
            eDetalleCita detalleCita = new eDetalleCita()
            {
                idServicio = idservicio,
                subTotal = subtotal,
                idCita = idcita
            };

            return detallecitad.Insertar(detalleCita);
        }

        public List<eDetalleCita> ListarDetalleCitas()
        {
            return detallecitad.ListarTodo();
        }

        public List<eDetalleCita> listarDetalle(int idCita)
        {
            List<eDetalleCita> lis = detallecitad.ListarTodo().FindAll(delegate(eDetalleCita valor){
                return valor.idCita==idCita;
            });

            return lis;
        }
        public List<eDetalleCita> DetalleXCita(int idCita)
        {
            return ListarDetalleCitas().FindAll(delegate (eDetalleCita valor)
            {
                return valor.idCita == idCita;
            });
            //return detallecitad.ListarxIDCita(idCita);
        }

    }
}
