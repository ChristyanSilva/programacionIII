using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IServicio<T>
    {
        string Guardar(T vehiculo);
        string Borrar(T vehiculo);
        string Editar(T oldVehiculo, T UpdateVehiculo);
        List<T> Obtener();
        T BuscarporPlaca(string Placa);
        bool Existencia(T vehiculo);
    }
}
