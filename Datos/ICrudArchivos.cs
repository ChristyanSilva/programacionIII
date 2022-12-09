using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICrudArchivos <T>   {
        bool actualizar(List<T> var);// eliminar y actualizar
        List<T> obtener();
        T Mappear(string linea);
    }
}
