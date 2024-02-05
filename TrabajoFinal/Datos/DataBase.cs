using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    class DataBase
    {
        private SqlConnection conn;
        public SqlConnection ConectaDb()
        {
            try
            {
                string cadenaConexion = "Data Source=DESKTOP-36TM5U9; Initial Catalog=DATOSBASETF; Integrated Security=True";
                conn = new SqlConnection(cadenaConexion);
                conn.Open();
                return conn;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
        public void DesconectaDb()
        {
            conn.Close();
        }
    }
}
