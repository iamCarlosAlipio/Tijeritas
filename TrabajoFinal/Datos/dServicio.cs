using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dServicio
    {
        DataBase db = new DataBase();
        public string Insertar(eServicio obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Servicio(nombre,precio,estado) values('{0}',{1},'{2}')", obj.nombreServicio,obj.precio,obj.estado);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Se registro correctamente el servicio";
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
        public string Modificar(eServicio obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Servicio set nombre='{0}',precio={1},estado='{2}' where idServicio={3}", obj.nombreServicio,obj.precio,obj.estado,obj.id);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Se modifico correctamente la informacion del servicio";
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
        public List<eServicio> ListarTodo()
        {
            try
            {
                List<eServicio> lsServicios = new List<eServicio>();
                eServicio servicio = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select idServicio, nombre,precio,estado from Servicio", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    servicio = new eServicio();
                    servicio.id = (int)reader["idServicio"];
                    servicio.nombreServicio = (string)reader["nombre"];
                    servicio.precio = (decimal)reader["precio"];
                    servicio.estado = (string)reader["estado"];
                    lsServicios.Add(servicio);
                }
                reader.Close();
                return lsServicios;
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

        //public eServicio SerXDetalleID(int id)
        //{
        //    try
        //    {

        //        eServicio servicio = null;
        //        SqlConnection con = db.ConectaDb();
        //        string aux = string.Format("SELECT precio, nombre FROM Servicio JOIN Detalle ON Servicio.id = Detalle.idServicio  WHERE Detalle.idServicio = {0}", id);
        //        SqlCommand cmd = new SqlCommand(aux, con);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            servicio = new eServicio();
        //            ////servicio.id = (int)reader["idServicio"];
        //            servicio.nombreServicio = (string)reader["a.nombre"];
        //            servicio.precio = (decimal)reader["a.precio"];
        //            //servicio.estado = (string)reader["estado"];

        //        }
        //        reader.Close();
        //        return servicio;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        db.DesconectaDb();
        //    }

        //}
    }
}
