using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class RepositorioVehicular : Archivo, ICrudArchivos<Vehiculo>
    {
        public RepositorioVehicular()
        {

        }
        public List<Vehiculo> obtener()
        {
            try
            {
                List<Vehiculo> vehiculos = new List<Vehiculo>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    vehiculos.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return vehiculos;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Vehiculo Mappear(string linea)
        {
            try
            {
                var vehiculo = new Vehiculo();
                vehiculo.marca = (linea.Split(';')[0]);
                vehiculo.placa = (linea.Split(';')[1]);
                vehiculo.aniosdeUso = int.Parse(linea.Split(';')[2]);
                vehiculo.tipoGasolina = (linea.Split(';')[3]);
                vehiculo.kilometraje = double.Parse(linea.Split(';')[4]);
                vehiculo.estadodelVehiculo = (linea.Split(';')[5]);
                return vehiculo;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool actualizar(List<Vehiculo> vehiculos)
        {
            try
            {
                var sw = new StreamWriter(ruta, false);
                foreach (var item in vehiculos)
                {
                    sw.WriteLine(item.ToString());
                }
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
