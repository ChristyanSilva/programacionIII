using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioConductor
    {
        Datos.RepositorioConductor repositorioConductor= new Datos.RepositorioConductor();
        public ServicioConductor()
        {

        }

        public bool Guardardb(Conductor c)
        {
            return repositorioConductor.Guardardb(c);
        }

        public DataTable ListarTodo()
        {
            return Datos.RepositorioConductor.listarTodo();
        }

        public Conductor Consultar(string nombre, string apellido)
        {
            return  Datos.RepositorioConductor.Consultar(nombre, apellido);
        }

        public static bool Actualizar(Conductor c)
        {
            return Datos.RepositorioConductor.Actualizar(c);
        }

        public static bool Eliminar(string nombre, string apellido)
        {
            return Datos.RepositorioConductor.Eliminar(nombre, apellido);
        }
    }
}
