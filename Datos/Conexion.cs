using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public SqlConnection dbConnection;

        public Conexion()
        {
            dbConnection = new SqlConnection("Data Source=DESKTOP-IVBU7DH;Initial Catalog=SILVADB;Integrated Security=True");
        }

        public void Conectar()
        {
            dbConnection.Open();
        }

        public void Desconectar()
        {
            dbConnection.Close();
        }

    }   
}
