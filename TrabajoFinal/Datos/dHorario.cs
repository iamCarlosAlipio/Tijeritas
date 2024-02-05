using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dHorario
    {
        DataBase db = new DataBase();
        public void Insertar(eHorario obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Horario(dia,mes,año,hora,estado,cuposMAx,cantCupos) values({0},{1},{2},'{3}','{4}',{5},{6})", obj.dia, obj.mes, obj.anio, obj.hora, obj.estado,obj.cantidadCuposMax,obj.cuposDisponibles);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                //return "Se inserto correctamente el horario";
            }
            catch (Exception ex)
            {
               //ex.Message
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Modificar(eHorario obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Horario set estado='{0}',cuposMax={1} where idHorario={2}", obj.estado,obj.cantidadCuposMax,obj.idHorario);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Se modificó el horario correctamente";
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
        public void ModificarCuposDisponibles(int cant,int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Horario set cantCupos={0} where idHorario={1}",cant,id);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                //return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        //public string Eliminar(int id)
        //{
        //    try
        //    {
        //        SqlConnection con = db.ConectaDb();
        //        string delete = string.Format("delete from Horario where idHorario={0}", id);
        //        SqlCommand cmd = new SqlCommand(delete, con);
        //        cmd.ExecuteNonQuery();
        //        return "elimino";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //    finally
        //    {
        //        db.DesconectaDb();
        //    }
        //}
        public List<eHorario> ListarTodo()
        {
            try
            {
                List<eHorario> lsHorarios = new List<eHorario>();
                eHorario horario = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select idhorario,dia,mes,año,hora,estado,cuposMax,cantCupos from Horario", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    horario = new eHorario();
                    horario.idHorario = (int)reader["idHorario"];
                    horario.dia = (int)reader["dia"];
                    horario.mes = (int)reader["mes"];
                    horario.anio = (int)reader["año"];
                    horario.hora = (string)reader["hora"];
                    horario.cuposDisponibles = (int)reader["cantCupos"];
                    horario.cantidadCuposMax = (int)reader["cuposMax"];
                    horario.estado = (string)reader["estado"];
                    lsHorarios.Add(horario);
                }
                reader.Close();
                return lsHorarios;
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

    }
}
