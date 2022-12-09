using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Datos; 

namespace Datos
{
    public class ConductorCAD
    {
        public static bool Guardardb(Conductor c)
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                // SQL Comando
                string queryText = "INSERT INTO conductores (nombres, apellidos, " +
                    "fechanacimiento, anioexp) VALUES ('" + c.nombre + "','" + c.apellido +
                    "','" + c.fechaNacimiento + "'," + c.aniosdeExperiencia + ")";
                DbCommand newCommand = new SqlCommand(queryText);
                newCommand.Connection = sqlServerConnection.dbConnection;
                int cantidad = newCommand.ExecuteNonQuery();
                sqlServerConnection.Desconectar();
                
                if (cantidad==1)
                {
                    return true;
                }else
                {
                    return false;
                }                  
            }
            catch(Exception)
            {
                return false;
            }
        }

        
        public static DataTable listar()
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "SELECT * from conductores;";
                SqlCommand comando = new SqlCommand(sql, sqlServerConnection.dbConnection);
                SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlServerConnection.Desconectar();
                return dataTable;
            }

            catch (Exception)
            {
                return null;
            }

        }

        
        public static Conductor Consultar(string nombre, string apellido)
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "SELECT * FROM conductores WHERE nombres= '"+nombre+"' or apellidos= '"+apellido+"';";
                SqlCommand comando = new SqlCommand(sql, sqlServerConnection.dbConnection);
                SqlDataReader dataReader = comando.ExecuteReader();
                Conductor co = null;
                if (dataReader.Read())
                {
                    co = new Conductor
                    {
                        nombre = dataReader["nombres"].ToString(),
                        apellido = dataReader["apellidos"].ToString(),
                        fechaNacimiento = dataReader["fechanacimiento"].ToString()
                    };
                    ;
                    co.aniosdeExperiencia= Convert.ToInt32(dataReader["anioexp"].ToString());
                }
                sqlServerConnection.Desconectar();
                return co;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Actualizar(Conductor c)
        {
            try
            {
                bool updatedOK = false;
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "UPDATE conductores SET apellidos='" + c.apellido + "',fechanacimiento='" + c.fechaNacimiento + "',anioexp=" + c.aniosdeExperiencia + " WHERE nombres='" + c.nombre + "';";

                SqlCommand comando = new SqlCommand(sql, sqlServerConnection.dbConnection);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    updatedOK = true;
                }

                sqlServerConnection.Desconectar();
                return updatedOK;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Eliminar(string nombre, string apellido)
        {
            try
            {
                bool deletedOK = false;
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();

                string sql = "DELETE FROM conductores WHERE nombres='" + nombre + "' AND apellidos='" + apellido + "';";

                SqlCommand comando = new SqlCommand(sql, sqlServerConnection.dbConnection);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    deletedOK = true;
                }
                sqlServerConnection.Desconectar();
                return deletedOK;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
    }
}
