using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VehiculoCAD
    {
        /*
        public static bool Guardardb(Vehiculo v)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO vehiculo (marca,placa,aniosdeUso,tipoGasolina,kilometraje,estadodelVehiculo,conductorAsignado) VALUES ('" + v.marca + "','" + v.placa + "'," + v.aniosdeUso + ",'" + v.tipoGasolina + "',"+v.kilometraje+",'"+v.estadodelVehiculo+"',"+v.idConductorAsignado+")";
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

        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * from vehiculo;";
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
        public static Vehiculo Consultar(string marca, string placa)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM vehiculo WHERE marca= '" + marca + "' or placa= '" + placa + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
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

                    con.desconectar();
                    return v;
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

        public static bool Actualizar(Vehiculo v)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE vehiculo SET marca='" + v.marca + "',aniosdeUso=" + v.aniosdeUso + ",tipoGasolina='" + v.tipoGasolina+",kilometraje=" +v.kilometraje+",estadodelVehiculo='"+v.estadodelVehiculo+"',conductorAsignado='"+v.idConductorAsignado+ "' WHERE placa=" + v.placa + ";";

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

        public static bool Eliminar(string placa)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM vehiculo WHERE placa='"+placa+ "';";

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
        */
    }
}
