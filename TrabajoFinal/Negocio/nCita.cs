using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class nCita
    {
        dCita datoCita;
        public nCita()
        {
            datoCita = new dCita();
        }
        public string RegistrarCita(int idninio, int idhorario,decimal totall,string estado)
        {
            eCita entidadCita = new eCita()
            {
                idNinio = idninio,
                idHorario= idhorario,
                total=totall,
                estado=estado
            };
            return datoCita.Insertar(entidadCita);
        }
        public string ModificarCita(int idninio, int idhorario, decimal totall, string estado,int idCita)
        {
            eCita entidadCita = new eCita()
            {
                idNinio = idninio,
                idHorario = idhorario,
                total = totall,
                estado = estado,
                codigo=idCita

            };
            return datoCita.Modificar(entidadCita);
        }
        public List<eCita> ListarCitas()
        {
            return datoCita.ListarTodo();
        }

        public int RegresarCodigo()
        {
            return datoCita.RegresarIdCita();
        }

        public int cantidad_CitasxHora(string hora, DateTime desde, DateTime hasta)
        {
            nHorario auxhora = new nHorario();
            dCita datoCita = new dCita(); ;

            //Forma Simplificada 
            return datoCita.ListarTodo().FindAll(delegate (eCita value)
            {
                int mes = auxhora.get_horario(value.idHorario).mes;
                int anio = auxhora.get_horario(value.idHorario).anio;
                int dia = auxhora.get_horario(value.idHorario).dia;
                string fec = anio.ToString() + "/" + mes.ToString() + "/" + dia.ToString();
                DateTime fecha = Convert.ToDateTime(fec);

                return (auxhora.get_horario(value.idHorario).hora == hora && fecha <= hasta && fecha >= desde);

            }).Count();

        }

        public bool ExisteCita(int cod)
        {
            return datoCita.ListarTodo().Exists(delegate (eCita valor)
            {
                return valor.codigo == cod;
            });
        }

        public List<eCita> ListarSeleccionandos(string Campo, string Criterio)
        {
            List<eCita> temp = new List<eCita>();

            temp = datoCita.ListarTodo().FindAll(delegate (eCita value)
            {

                if (Campo == "Codigo") return value.codigo == Convert.ToInt32(Criterio);
                //else if (Campo == "Apellido") return value.apellido == Criterio;
                //else if (Campo == "Documento") return value.documento == Criterio;
                //else if (Campo == "Nacimiento") return value.fechaNacido == Convert.ToDateTime(Criterio);
                return false;
            });

            return temp;
        }


        public eCita ExisteCitaxIDNinioYIdHorario(int idNinio,int idHorario)
        {
            return ListarCitas().Find(delegate (eCita valor)
            {
                return valor.idHorario == idHorario && valor.idNinio == idNinio&&valor.estado=="Activo";
            });

        }
        public List<eCita> CitasXdniRepre(string DNI)
        {
            //Conseguimos el id DEL DNI

            dRepresentante AuxdRepresentante = new dRepresentante();
            int id = AuxdRepresentante.ListarTodo().Find(delegate (eRepresentante value) { return value.documento == DNI; }).idRepresentante;

            //Consigue a los niños del Representante
            dNinio dnNinio = new dNinio();
            List<eNinio> lsninios = new List<eNinio>();
            lsninios = dnNinio.NinioXidRepre(id);


            //Busca las citas de los niños

            List<eCita> Temp = new List<eCita>();
            nCita AuxnCita = new nCita();

            Temp = AuxnCita.ListarCitas().FindAll((delegate (eCita value) { return lsninios.Exists(delegate (eNinio va) { return va.idNinio == value.idNinio; }); }));

            return Temp;

        }
    }

}
