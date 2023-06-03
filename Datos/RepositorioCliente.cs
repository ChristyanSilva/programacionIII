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
    public class RepositorioCliente
    {
        public RepositorioCliente()
        {

        }

        public bool Guardardb(Cliente c)
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                // SQL Comando
                string queryText = "INSERT INTO conductores (nombres, apellidos, " +
                    "fechanacimiento, nombreUsuario, contrasenia, cargo) VALUES ('" + c.nombre + "','" + c.apellido +
                    "','" + c.fechaNacimiento + "'," + c.nombreUsuario+ "','" + c.contrasenia + "','" + c.cargo+"')";
                DbCommand newCommand = new SqlCommand(queryText);
                newCommand.Connection = sqlServerConnection.dbConnection;
                int cantidad = newCommand.ExecuteNonQuery();
                sqlServerConnection.Desconectar();

                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable listarTodo() // getall(dto)
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "SELECT * from clientes;";
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

        public static Cliente Consultar(string nombre, string apellido)
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "SELECT * FROM clientes WHERE nombres= '" + nombre + "' or apellidos= '" + apellido + "';";
                SqlCommand comando = new SqlCommand(sql, sqlServerConnection.dbConnection);
                SqlDataReader dataReader = comando.ExecuteReader();
                Cliente co = null;
                if (dataReader.Read())
                {
                    co = new Cliente
                    {
                        nombre = dataReader["nombres"].ToString(),
                        apellido = dataReader["apellidos"].ToString(),
                        fechaNacimiento = dataReader["fechanacimiento"].ToString()
                    };
                    
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
                string sql = "UPDATE clientes SET apellidos='" + c.apellido + "',fechanacimiento='"
                    + c.fechaNacimiento + "'," +"WHERE nombres='" + c.nombre + "';";

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

                string sql = "DELETE FROM clientes WHERE nombres='" + nombre + "' AND apellidos='" + apellido + "';";

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
