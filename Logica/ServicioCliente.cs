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
    public class ServicioCliente
    {
        Datos.RepositorioCliente repositorioCliente = new RepositorioCliente();
        public ServicioCliente()
        {            
        }
        public bool Guardardb(Cliente c)
        {
            return repositorioCliente.Guardardb(c);
        }

        public DataTable ListarTodo()
        {
            return Datos.RepositorioCliente.listarTodo();
        }

        public Cliente Consultar(string nombre, string apellido)
        {
            return Datos.RepositorioCliente.Consultar(nombre, apellido);
        }

        public static bool Actualizar(Conductor c)
        {
            return Datos.RepositorioCliente.Actualizar(c);
        }

        public static bool Eliminar(string nombre, string apellido)
        {
            return Datos.RepositorioCliente.Eliminar(nombre, apellido);
        }

    }
}
