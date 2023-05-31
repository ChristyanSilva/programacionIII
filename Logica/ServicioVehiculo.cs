using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioVehiculo
    {
       

        public bool Guardardb(Vehiculo v)
        {
            return RepositorioVehiculo.Guardardb(v);
        }

        public DataTable ListarTodo()
        {
            return RepositorioVehiculo.listar();
        }

        public Vehiculo Consultar(string marca, string placa)
        {
            return RepositorioVehiculo.Consultar(marca, placa);
        }

        public static bool Actualizar(Vehiculo v)
        {
            return RepositorioVehiculo.Actualizar(v);
        }

        public static bool Eliminar(string placa)
        {
            return RepositorioVehiculo.Eliminar(placa);
        }
    }
}
