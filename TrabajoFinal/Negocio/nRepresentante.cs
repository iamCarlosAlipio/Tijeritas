using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nRepresentante
    {
        dRepresentante datoRepresentante;

        public nRepresentante()
        {
            datoRepresentante = new dRepresentante();
        }
        public string RegistrarRepresentante(string tipo, string documento, string nombre, string apellido, string email, string numero, DateTime nacimiento)
        {
            eRepresentante entidadRepresentante = new eRepresentante()
            {
                tipoDocumento = tipo,
                documento = documento,
                nombre = nombre,
                apellido = apellido,
                email = email,
                numeroCel = numero,
                fechaNacimiento = nacimiento

            };

            return datoRepresentante.Insertar(entidadRepresentante);
        }

        public string ModificarRepresentate(string tipo, string documento, string nombre, string apellido, string email, string numero, DateTime nacimiento,int id)
        {
            eRepresentante entidadRepresentante = new eRepresentante()
            {
                idRepresentante = id,
                tipoDocumento = tipo,
                documento = documento,
                nombre = nombre,
                apellido = apellido,
                email = email,
                numeroCel = numero,
                fechaNacimiento = nacimiento
            };
            return datoRepresentante.Modificar(entidadRepresentante);
        }


        public List<eRepresentante> ListarRepresentantes()
        {
            return datoRepresentante.ListarTodo();
        }

        public List<eRepresentante> ListarSeleccionandos(string Campo, string Criterio)
        {
            List<eRepresentante> temp = new List<eRepresentante>();

            temp = datoRepresentante.ListarTodo().FindAll(delegate (eRepresentante value) {

                if (Campo == "Nombre") return value.nombre == Criterio;
                else if (Campo == "Apellido") return value.apellido == Criterio;
                else if (Campo == "Documento") return value.documento == Criterio;
                else if (Campo == "Email") return value.email == Criterio;
                else if (Campo == "Telefono") return value.numeroCel == Criterio;
                else if (Campo == "Nacimiento") return value.fechaNacimiento == Convert.ToDateTime(Criterio);

                return false;
            });
            return temp;
        }

        public List<eRepresentante> ListarSegunFecha(int diaI, int mesI, int diaF, int mesF)
        {
            return datoRepresentante.ListarTodo().FindAll(delegate (eRepresentante valor)
            {
                int dia = Convert.ToInt32(valor.fechaNacimiento.ToString("dd"));
                int mes = Convert.ToInt32(valor.fechaNacimiento.ToString("MM"));
                return dia >= diaI && mes >= mesI && dia <= diaF && mes <= mesF;
            });
        }

        public eRepresentante RepresentateXDNI(string dni)
        {
            return ListarRepresentantes().Find(delegate (eRepresentante valor)
            {
                return valor.documento == dni;
            });
            //return datoRepresentante.BuscarPorDNI(dni);
        }

        public bool existeRepresentante(string dni)
        {
            return ListarRepresentantes().Exists(delegate(eRepresentante valor)
            {
                return valor.documento == dni;
            });
        }


    }
}
