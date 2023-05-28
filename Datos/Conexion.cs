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
            dbConnection = new SqlConnection("Data Source=DESKTOP-MS21OKB\\SQLEXPRESS;Initial Catalog=tax-manager;Integrated Security=True");
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
