using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Logica
{
    public class RepositorioVehiculo
    {
        
        public static bool Guardardb(Vehiculo v)
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "INSERT INTO vehiculo (marca,placa,aniosdeUso,tipoGasolina,kilometraje,estadodelVehiculo,conductorAsignado) VALUES ('" + v.marca + "','" + v.placa + "'," + v.aniosdeUso + ",'" + v.tipoGasolina + "',"+v.kilometraje+",'"+v.estadodelVehiculo+"',"+v.idConductorAsignado+")";
                DbCommand newCommand = new SqlCommand(sql);
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
            catch (Exception ex)
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
                string sql = "SELECT * from vehiculo;";
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
        public static Vehiculo Consultar(string marca, string placa)
        {
            try
            {
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "SELECT * FROM vehiculo WHERE marca= '" + marca + "' or placa= '" + placa + "';";
                
                SqlCommand comando = new SqlCommand(sql, sqlServerConnection.dbConnection);
                SqlDataReader dataReader = comando.ExecuteReader();
                Vehiculo v = new Vehiculo();
                if (dataReader.Read())
                {
                    v.marca = dataReader["marca"].ToString();
                    v.placa = dataReader["placa"].ToString();
                    v.aniosdeUso = Convert.ToInt32(dataReader["aniosdeuso"].ToString());
                    v.tipoGasolina = dataReader["tipoGasolina"].ToString();
                    v.kilometraje = Convert.ToDouble(dataReader["kilometraje"].ToString());
                    v.estadodelVehiculo= dataReader["estadodelvehiculo"].ToString();
                    v.idConductorAsignado= Convert.ToInt32(dataReader["conductorAsignado"].ToString());

                    sqlServerConnection.Desconectar();
                    return v;
                }
                else
                {

                    sqlServerConnection.Desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool Actualizar(Vehiculo v)
        {
            try
            {
                bool updatedOK = false;
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "UPDATE vehiculo SET marca='" + v.marca + "',aniosdeUso=" + v.aniosdeUso + ",tipoGasolina='" + v.tipoGasolina+",kilometraje=" +v.kilometraje+",estadodelVehiculo='"+v.estadodelVehiculo+"',conductorAsignado='"+v.idConductorAsignado+ "' WHERE placa=" + v.placa + ";";

                SqlCommand comando = new SqlCommand(sql);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    updatedOK = true;
                }

                sqlServerConnection.Desconectar();
                return updatedOK;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Eliminar(string placa)
        {
            try
            {
                bool deletedOK = false;
                Conexion sqlServerConnection = new Conexion();
                sqlServerConnection.Conectar();
                string sql = "DELETE FROM vehiculo WHERE placa='"+placa+ "';";

                SqlCommand comando = new SqlCommand(sql, sqlServerConnection.dbConnection);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    deletedOK = true;
                }
                sqlServerConnection.Desconectar();
                return deletedOK;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
    }
}
