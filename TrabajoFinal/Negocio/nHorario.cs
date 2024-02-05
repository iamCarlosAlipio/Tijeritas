using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nHorario
    {
        dHorario datoHorario;

        public nHorario()
        {
            datoHorario = new dHorario();
        }
        public void RegistrarHorario(int hdia, int hmes, int hanio, string hhora, string hestado,int cntmax)
        { 
            eHorario entidadHorario = new eHorario()
            {
                dia=hdia,
                mes=hmes,
                anio=hanio,
                hora=hhora,
                estado=hestado,
                cantidadCuposMax= cntmax,
                cuposDisponibles=0

            };

            datoHorario.Insertar(entidadHorario);
        }

        public string ModificarHorario(string hestado,int id,int cntmax)
        {
            eHorario entidadHorario = new eHorario()
            {
                idHorario=id,
                estado = hestado,
                cantidadCuposMax = cntmax,

            };
            return datoHorario.Modificar(entidadHorario);
        }

        private void  ModificarHorarioDispon(int id, int cupodis)
        {
            datoHorario.ModificarCuposDisponibles(cupodis, id);
        }
        //public string EliminarHorario(int idHorario)
        //{
        //    return datoHorario.Eliminar(idHorario);
        //}

        public List<eHorario> ListarHorario()
        {
            return datoHorario.ListarTodo();
        }

        public eHorario DevolverHorario(int id)
        {
            eHorario nuevo = null;
            List<eHorario> list = datoHorario.ListarTodo();

            foreach (eHorario valor in list)
            {
                if (valor.idHorario == id) nuevo = valor;
            }
            return nuevo;
        }

        public List<string> HorasDistintas()
        {
            dHorario datoHorario = new dHorario();

            return datoHorario.ListarTodo().Select(x => x.hora).Distinct().ToList();
        }

        public eHorario get_horario(int id)
        {
            dHorario datoHorario = new dHorario();

            return datoHorario.ListarTodo().Find(delegate (eHorario value) { return value.idHorario == id; });
        }

        public List<eHorario> ListarHorarioFcha(DateTime fecha)
        {
            int dia = Convert.ToInt32(fecha.ToString("dd"));
            int mes = Convert.ToInt32(fecha.ToString("MM"));
            int anio = Convert.ToInt32(fecha.ToString("yyyy"));
            return datoHorario.ListarTodo().FindAll(delegate (eHorario valor)
            {
                return valor.dia == dia && valor.mes == mes && valor.anio == anio && valor.estado == "Activo              ";
            });
        }
        public List<eHorario> ListarHorarioDisponibles()
        {
            return datoHorario.ListarTodo().FindAll(delegate (eHorario valor)
            {
                return valor.cuposDisponibles < valor.cantidadCuposMax && valor.estado!="Inactivo            ";
            });
        }

        public void AumentarCupo(int id)
        {
            eHorario valor = ListarHorario().Find(delegate(eHorario x)
            {
                return x.idHorario == id;
            });
            if(valor.cuposDisponibles <= valor.cantidadCuposMax && valor.cuposDisponibles-1 >= 0)
            {
                datoHorario.ModificarCuposDisponibles(valor.cuposDisponibles - 1, valor.idHorario);
            }
        }
        public void DisminuiorCupo(int id)
        {
            eHorario valor = ListarHorario().Find(delegate (eHorario x)
            {
                return x.idHorario == id;
            });
            if (valor.cuposDisponibles+1 <= valor.cantidadCuposMax && valor.cuposDisponibles>= 0)
            {
                datoHorario.ModificarCuposDisponibles(valor.cuposDisponibles + 1, valor.idHorario);
            }
        }
        public void InhabilitarHorarios()
        {
            nHorario aux = new nHorario();
            if (aux.ListarHorario() != null)
            {
                foreach (eHorario it in aux.ListarHorario())
                {
                    string date = it.anio.ToString() + "-" + it.mes.ToString() + "-" + it.dia.ToString() + " " + hora(it.hora);
                    int x = Convert.ToInt32(hora(it.hora));
                    DateTime nuevo = new DateTime(it.anio, it.mes, it.dia, x, 0, 0);

                    if (nuevo > DateTime.Now)
                    {
                        //it.estado = "Inactivo            ";
                        it.estado = "Activo              ";
                        datoHorario.Modificar(it);
                    }
                }
            }
        }
        public string hora(string ho)
        {
            
            return ho.Substring(0,2);
        }

        public bool ExisteHorario(DateTime fecha,string seleccion)
        {
            List<eHorario> ls = ListarHorario();
            bool retorno = false;

            foreach(eHorario horario in ls)
            {
                DateTime comparador = new DateTime(horario.anio, horario.mes, horario.dia);
                if (comparador == fecha && horario.hora == seleccion) retorno = true;
            }
            return retorno;
        }

        public eHorario DarHorario(DateTime fecha, string seleccion)
        {
            List<eHorario> ls = ListarHorario();
            eHorario retorno = null;

            foreach (eHorario horario in ls)
            {
                DateTime comparador = new DateTime(horario.anio, horario.mes, horario.dia);
                if (comparador.ToShortDateString() == fecha.ToShortDateString() && horario.hora == seleccion) retorno = horario;
            }
            return retorno;
        }
    }
}
