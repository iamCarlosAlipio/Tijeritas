using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class nServicio
    {
        dServicio datoServicio;
        public nServicio()
        {
            datoServicio = new dServicio();
        }
        public string RegistrarServicio(string nombreServi,decimal Precio,string Estado)
        {
            eServicio entidadServicio = new eServicio()
            {
                nombreServicio = nombreServi,
                precio= Precio,
                estado=Estado
            };
            return datoServicio.Insertar(entidadServicio);
        }
        public string ModificarServicio(string nombreServi,decimal precioS,string Estado,int iD)
        {
            eServicio entidadServicio = new eServicio()
            {
                id=iD,
                nombreServicio = nombreServi,
                precio=precioS,
                estado=Estado
            };
            return datoServicio.Modificar(entidadServicio);
        }
        public List<eServicio> ListarServicio()
        {
            return datoServicio.ListarTodo();
        }

        public eServicio DevolverServicio(int id)
        {
            eServicio nuevo = null;
            List<eServicio> list = datoServicio.ListarTodo();
            
            foreach(eServicio valor in list)
            {
                if (valor.id == id) nuevo = valor;
            }
            return nuevo;
        }
        public eServicio DevolverServicioXDetalleID(int Detalleid)
        {
            return ListarServicio().Find(delegate (eServicio valor)
            {
                return valor.id == Detalleid;
            });
            //return datoServicio.SerXDetalleID(Detalleid);
        }
    }

}
