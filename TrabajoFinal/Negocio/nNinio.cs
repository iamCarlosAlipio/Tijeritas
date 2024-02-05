using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nNinio
    {
        dNinio datoNinio;
        nRepresentante negocioRepresenante = new nRepresentante();

        public nNinio()
        {
            datoNinio = new dNinio();
        }

        public string RegistrarNinio(string doc_ninio, string tipo, string nombreninio, DateTime fecha,int id, string apelli)
        {
            eNinio entidadNinio = new eNinio()
            {
                Nombre = nombreninio,
                tipoDocumento = tipo,
                fechaNacido = fecha,
                apellido = apelli,
                idRepresentante = id,
                documento = doc_ninio
            };

            return datoNinio.Insertar(entidadNinio);
        }

        public string ModificarNinio(string doc, string tipo, string nombreninio, DateTime fecha, int id, string apelli,int idninio)
        {
            eNinio entidadNinio = new eNinio()
            {
                idNinio= idninio,
                Nombre = nombreninio,
                tipoDocumento = tipo,
                fechaNacido = fecha,
                apellido = apelli,
                documento = doc,
                idRepresentante = id
            };

            return datoNinio.Modificar(entidadNinio);
        }

        public List<eNinio> ListarNinio()
        {
            return datoNinio.ListarTodo();
        }

        public List<eNinio> ListarSeleccionandos(string Campo, string Criterio)
        {
            List<eNinio> temp = new List<eNinio>();

            temp = datoNinio.ListarTodo().FindAll(delegate (eNinio value) {

                if (Campo == "Nombre") return value.Nombre == Criterio;
                else if (Campo == "Apellido") return value.apellido == Criterio;
                else if (Campo == "Documento") return value.documento == Criterio;
                else if (Campo == "Nacimiento") return value.fechaNacido == Convert.ToDateTime(Criterio);

                return false;
            });

            return temp;
        }
        public eRepresentante RepresntanteNinio(int id)
        {
            eRepresentante nuevo=null;
            foreach(eRepresentante repre in negocioRepresenante.ListarRepresentantes())
            {
                if (id == repre.idRepresentante)
                {
                    nuevo = repre;
                }
            }
            return nuevo;
        }
        public eNinio getNinio(string dni)
        {
            eNinio nuevo = null;
            List<eNinio> lsninio = ListarNinio();
            foreach (eNinio ninio in lsninio)
            {
                if (ninio.documento == dni)
                {
                    nuevo = ninio;
                }
            }
            return nuevo;
        }

        public List<eNinio> ListarSegunFecha(int diaI,int mesI, int diaF,int mesF)
        {
            return datoNinio.ListarTodo().FindAll(delegate(eNinio valor)
            {
                int dia = Convert.ToInt32(valor.fechaNacido.ToString("dd"));
                int mes = Convert.ToInt32(valor.fechaNacido.ToString("MM"));
                return dia >= diaI && mes >= mesI && dia <= diaF && mes <= mesF;
            });
        }

        public bool ExisteNinio(string doc)
        {
            return datoNinio.ListarTodo().Exists(delegate (eNinio valor)
            {
                return valor.documento == doc;
            });
        }
        public List<eCita> Consulta(string DNI)
        {
            nCita aux = new nCita();
            //Con el Dni buscamos el id representante
            nRepresentante repreaxu = new nRepresentante();
            int id = 1;//repreaxu.RepresentateXDNI(DNI).idRepresentante;
            //Buscamos el id del los niños con los representantes
            nNinio negoninio = new nNinio();
            List<eNinio> listNino = new List<eNinio>();
            negoninio.ListarNinio().FindAll(delegate (eNinio value) { return value.idRepresentante == id; });
            //Retornamos las Buscamos Las citas con los ID de los niños
            return aux.ListarCitas().FindAll(delegate (eCita value) {
                return listNino.Exists(delegate (eNinio val) { return val.idNinio == value.idNinio; });
            });
        }
    }
}
