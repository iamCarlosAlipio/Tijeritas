using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dNinio
    {
        DataBase db = new DataBase();
        public string Insertar(eNinio obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Ninio(documento,tipoDocumento,idRepresentante,nombre,apellido,fechaNacimiento) values('{0}' , '{1}' , {2} , '{3}', '{4}' , '{5}')",
                    obj.documento, obj.tipoDocumento, obj.idRepresentante, obj.Nombre, obj.apellido, obj.fechaNacido.ToString("yyyy'-'MM'-'dd"));
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "El niño fue registrado con exito";

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


        public string Modificar(eNinio obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Ninio set nombre = '{0}',apellido='{1}', fechaNacimiento='{2}',idRepresentante={3},tipoDocumento='{4}',documento = '{5}' where idNinio = {6}", obj.Nombre, obj.apellido, obj.fechaNacido.ToString("yyyy'-'MM'-'dd"),obj.idRepresentante,obj.tipoDocumento,obj.documento,obj.idNinio);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Se modificó con exito la informacion del niño";

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

        public List<eNinio> ListarTodo()
        {
            try
            {
                List<eNinio> lsNinio = new List<eNinio>();
                eNinio ninio = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select idNinio,documento,tipoDocumento,nombre,fechaNacimiento,idRepresentante, apellido from Ninio", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ninio = new eNinio();
                    ninio.idNinio = (int)reader["idNinio"];
                    ninio.fechaNacido = (DateTime)reader["fechaNacimiento"];
                    ninio.Nombre = (string)reader["nombre"];
                    ninio.apellido = (string)reader["apellido"];
                    ninio.documento = (string)reader["documento"];
                    ninio.idRepresentante = (int)reader["idRepresentante"];
                    ninio.tipoDocumento = (string)reader["tipoDocumento"];
                    lsNinio.Add(ninio);
                }
                reader.Close();
                return lsNinio;
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
        public List<eNinio> NinioXidRepre(int id)
        {
            try
            {
                List<eNinio> lsNinio = new List<eNinio>();
                eNinio ninio = null;
                SqlConnection con = db.ConectaDb();
                string aux = string.Format("select idNinio FROM Ninio JOIN Representante ON Representante.idrepresentante = Ninio.idrepresentante WHERE Ninio.idrepresentante = {0}", id);
                SqlCommand cmd = new SqlCommand(aux, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ninio = new eNinio();
                    ninio.idNinio = (int)reader["idNinio"];
                    lsNinio.Add(ninio);
                }
                reader.Close();
                return lsNinio;
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
