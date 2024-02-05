using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dRepresentante
    {
        DataBase db = new DataBase();
        public string Insertar(eRepresentante obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Representante(documento, tipoDocumento, nombre, apellido, email, numeroCel, fechaNacimiento) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", obj.documento, obj.tipoDocumento, obj.nombre, obj.apellido, obj.email, obj.numeroCel, obj.fechaNacimiento.ToString("yyyy'-'MM'-'dd"));
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "El representante fue registrado con exito";
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
        public string Modificar(eRepresentante obj)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Representante SET nombre = '{0}',tipoDocumento='{1}',apellido='{2}', email='{3}', numeroCel='{4}', fechaNacimiento = '{5}',documento = '{6}'  Where idRepresentante = {7} ",
                    obj.nombre, obj.tipoDocumento, obj.apellido, obj.email, obj.numeroCel, obj.fechaNacimiento.ToString("yyyy'-'MM'-'dd"),obj.documento, obj.idRepresentante);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Se modificó con exito el la información del representante";
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
      
        public List<eRepresentante> ListarTodo()
        {
            try
            {
                List<eRepresentante> lsRepresentante = new List<eRepresentante>();
                eRepresentante representante = null;
                SqlConnection con = db.ConectaDb();

                SqlCommand cmd = new SqlCommand("select idRepresentante,documento, tipoDocumento, nombre, apellido, email, numeroCel, fechaNacimiento from Representante", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    representante = new eRepresentante();
                    representante.idRepresentante = (int)reader["idRepresentante"];
                    representante.documento = (string)reader["documento"];
                    representante.tipoDocumento = (string)reader["tipoDocumento"];
                    representante.nombre = (string)reader["nombre"];
                    representante.apellido = (string)reader["apellido"];
                    representante.email = (string)reader["email"];
                    representante.numeroCel = (string)reader["numeroCel"];
                    representante.fechaNacimiento = (DateTime)reader["fechaNacimiento"];

                    lsRepresentante.Add(representante);
                }
                reader.Close();

                return lsRepresentante;
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

        public eRepresentante BuscarPorDNI(string DNI)
        {
            try
            {
                eRepresentante Representante = null;
                SqlConnection con = db.ConectaDb();
                string select = string.Format("select idRepresentante, documento, tipoDocumento, nombre, apellido, email, numeroCel, fechaNacimiento where documento = '{0}'", DNI);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Representante.idRepresentante = (int)reader["idRepresentante"];
                    Representante.documento = (string)reader["documento"];
                    Representante.tipoDocumento = (string)reader["tipoDocumento"];
                    Representante.nombre = (string)reader["nombre"];
                    Representante.apellido = (string)reader["apellido"];
                    Representante.email = (string)reader["email"];
                    Representante.numeroCel = (string)reader["numeroCel"];
                    Representante.fechaNacimiento = (DateTime)reader["fechaNacimiento"];
                }
                reader.Close();
                return Representante;
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
