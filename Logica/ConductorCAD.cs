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
                Conexion con= new Conexion();
                con.conectar();
                string sql = "INSERT INTO conductores (nombres, apellidos, fechanacimiento, añoexp) VALUES ('" + c.nombre+ "','"+c.apellido+"','"+c.fechaNacimiento+"',"+c.aniosdeExperiencia+")";
                SqlCommand comando = new SqlCommand(sql);
                int cantidad = comando.ExecuteNonQuery();
                if(cantidad==1)
                {
                    con.desconectar();
                    return true;
                }else
                {
                    con.desconectar();
                    return false;
                }                  
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * from conductores;";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                con.desconectar();
                return dataTable;
            }

            catch (Exception ex)
            {
                return null;
            }

        }
        public static Conductor Consultar(string nombre, string apellido)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM conductores WHERE nombres= '"+nombre+"' or apellidos= '"+apellido+"';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dataReader = comando.ExecuteReader();
                Conductor co= new Conductor();
                if (dataReader.Read())
                {
                    co.nombre = dataReader["nombres"].ToString() ; 
                    co.apellido = dataReader["apellidos"].ToString(); 
                    co.fechaNacimiento= dataReader["fechanacimiento"].ToString(); ;
                    co.aniosdeExperiencia= Convert.ToInt32(dataReader["anioexp"].ToString());
                    con.desconectar();
                    return co;
                }
                else
                {

                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool Actualizar(Conductor c)
        {
            try
            {
                Conexion con = new Conexion();
                con.conectar();
                string sql = "UPDATE conductores SET apellidos='" + c.apellido + "',fechanacimiento='" + c.fechaNacimiento + "',anioexp=" + c.aniosdeExperiencia + " WHERE nombres='" + c.nombre + "';";

                SqlCommand comando = new SqlCommand(sql);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Eliminar(string nombre, string apellido)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM conductores WHERE nombres='" + nombre + " AND apellidos='" + apellido + "';";

                SqlCommand comando = new SqlCommand(sql);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
