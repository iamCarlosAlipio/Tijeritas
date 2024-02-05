using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data.SqlTypes;
namespace Datos
{
    public class dDetalleCita
    {
        DataBase db = new DataBase();

        //(EN DUDA PUESTO QUE EL DETALLE DE UN CITA ESTÁ A BASE DEL INSERTADO DE UNA CITA Y NO SERÍA INSERTAR, PREFERIBLE PONER TODOS LOS DATOS DE UNA CICTA EN LA ENTIDAD "CITA") 
        public string Insertar(eDetalleCita obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Detalle(idCita, idServicio, subTotal) values({0}, {1}, {2})", obj.idCita, obj.idServicio, obj.subTotal);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Insertado";
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
        //public string Modificar(eDetalleCita obj)
        //{
        //    try
        //    {
        //        SqlConnection con = db.ConectaDb(); //no es recomendable modificar el id de la misma entidad donde se está trabajando, ese atributo es un identificador que no debe ser cambiado.
        //        string update = string.Format("update Detalle set idServicio = {0}, SubTotal={1}, idCita={2} where idDetalle = '{3}'", obj.idServicio, obj.subTotal, obj.idCita, obj.idDetalle);
        //        SqlCommand cmd = new SqlCommand(update, con);
        //        cmd.ExecuteNonQuery();
        //        return "Modifico";
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
        public List<eDetalleCita> ListarTodo()
        {
            try
            {
                List<eDetalleCita> lsDetalleCita = new List<eDetalleCita>();
                eDetalleCita detallecita = null;
                SqlConnection con = db.ConectaDb();

                SqlCommand cmd = new SqlCommand("select idDetalle, idCita, idServicio, subTotal from Detalle", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    detallecita = new eDetalleCita();
                    detallecita.idDetalle = (int)reader["idDetalle"];
                    detallecita.idCita = (int)reader["idCita"];
                    detallecita.idServicio = (int)reader["idServicio"];
                    detallecita.subTotal = (decimal)reader["subTotal"];

                    lsDetalleCita.Add(detallecita);
                }
                reader.Close();

                return lsDetalleCita;
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
        //no se puede incluir una función para eliminar el detalle de una cita, puesto que si se elimina no existiría tal cita y sería redundante
        public List<eDetalleCita> ListarxIDCita(int id)
        {
            try
            {
                List<eDetalleCita> lsDetalleCita = new List<eDetalleCita>();
                eDetalleCita detallecita = null;
                SqlConnection con = db.ConectaDb();
                string aux = string.Format("select idDetalle FROM Detalle JOIN Cita ON Detalle.idCita = Cita.idCita WHERE Cita.idCita = {0}", id);
                SqlCommand cmd = new SqlCommand(aux, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    detallecita = new eDetalleCita();
                    detallecita.idDetalle = (int)reader["idDetalle"];
                    lsDetalleCita.Add(detallecita);
                }
                reader.Close();

                return lsDetalleCita;
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
        public eServicio SerXDetalleID(int id)
        {
            try
            {

                eServicio servicio = null;
                SqlConnection con = db.ConectaDb();
                string aux = string.Format("SELECT nombre, precio FROM Servicio JOIN Detalle ON Servicio.idServicio = Detalle.idServicio  WHERE Detalle.idServicio = {0}", id);
                SqlCommand cmd = new SqlCommand(aux, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    servicio = new eServicio();
                    servicio.nombreServicio = (string)reader["nombre"];
                    servicio.precio = (decimal)reader["precio"];
                }
                reader.Close();
                return servicio;
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
