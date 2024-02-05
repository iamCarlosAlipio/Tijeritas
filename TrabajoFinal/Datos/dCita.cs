using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dCita
    {
        DataBase db = new DataBase();
        public string Insertar(eCita obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Cita(idNinio,idHorario,total,estado) values({0},{1},{2},'{3}')", obj.idNinio, obj.idHorario,obj.total, obj.estado);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "La cita fue registrada con exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Modificar(eCita obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Cita set estado='{0}' where idCita={1}", obj.estado, obj.codigo);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "La cita fue cancelada con exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public List<eCita> ListarTodo()
        {
            try
            {
                List<eCita> lsCitas = new List<eCita>();
                eCita cita = null;//CD_servicoxCliente
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select idCita,idNinio,idHorario,total,estado from Cita", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cita = new eCita();
                    cita.codigo = (int)reader["idCita"];
                    cita.idHorario = (int)reader["idHorario"];
                    cita.idNinio = (int)reader["idNinio"];
                    cita.total = (decimal)reader["total"];
                    cita.estado = (string)reader["estado"];
                    lsCitas.Add(cita);
                }
                reader.Close();
                return lsCitas;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }

        }

        public int RegresarIdCita()
        {
            int aux=-1;
            List<eCita> listaCitas = ListarTodo();
            foreach(eCita valor in listaCitas)
            {
                aux = valor.codigo;
            }
            return aux;
        }

    }
}
