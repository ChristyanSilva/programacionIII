using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        protected string ruta;
        public Archivo(string fileNme)
        {
            ruta = fileNme;
        }
        public Archivo()
        {
            ruta = "Vehiculos.TXT";
        }

        public bool Guardar(Vehiculo vehiculo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(vehiculo.ToString());
                sw.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
