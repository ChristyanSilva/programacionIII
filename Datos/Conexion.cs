using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            con = new SqlConnection("Data Source= DESKTOP-MS21OKB\\SQLEXPRESS; Initial Catalog= tax-manager; Integrated Security= True");
        }

        public SqlConnection conectar()
        {
                con.Open();
                return con;
        }

        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }   
}
