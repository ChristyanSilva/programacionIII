using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioConductor : Archivo, ICrudArchivos<Conductor>
    {
        public bool actualizar(List<Conductor> conductores)
        {
            try
            {
                var sw = new StreamWriter(ruta, false);
                foreach (var item in conductores)
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

        public Conductor Mappear(string linea)
        {
            try
            {
                var conductor = new Conductor();
                conductor.nombre = (linea.Split(';')[0]);
                conductor.apellido = (linea.Split(';')[1]);
                conductor.fechaNacimiento = (linea.Split(';')[2]);
                return conductor;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Conductor> obtener()
        {
            try
            {
                List<Conductor> conductores = new List<Conductor>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    conductores.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return conductores;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
