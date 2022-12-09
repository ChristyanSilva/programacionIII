using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Logica
{
    public class ServicioVehiculo : IServicio<Vehiculo>
    {
        List<Vehiculo> vehiculos;
        RepositorioVehicular repositorioVehicular;
        public ServicioVehiculo()
        {
            repositorioVehicular = new RepositorioVehicular();
            vehiculos = repositorioVehicular.obtener();
        }

        public string Borrar(Vehiculo vehiculo)
        {
            vehiculos.Remove(vehiculo);
            repositorioVehicular.actualizar(vehiculos);
            Refresh();
            return $"el vehiculo se elimino correctamente con la placa {vehiculo.placa}";
        }
        void Refresh()
        {
            vehiculos = repositorioVehicular.obtener();
        }

        public string Editar(Vehiculo oldVehiculo, Vehiculo UpdateVehiculo)
        {
            oldVehiculo.marca = UpdateVehiculo.marca;
            oldVehiculo.placa = UpdateVehiculo.placa;
            oldVehiculo.aniosdeUso = UpdateVehiculo.aniosdeUso;
            oldVehiculo.tipoGasolina = UpdateVehiculo.tipoGasolina;
            oldVehiculo.kilometraje = UpdateVehiculo.kilometraje;
            oldVehiculo.estadodelVehiculo = UpdateVehiculo.estadodelVehiculo;
            var estado = repositorioVehicular.actualizar(vehiculos);
            Refresh();
            return estado ? $"Se ha actualizado el vehiculo{UpdateVehiculo.placa}" :
                $"ERROR al actualizar el vehiculo {UpdateVehiculo.placa}";
        }

        public bool Existencia(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> Obtener()
        {
            return vehiculos;
        }

        public Vehiculo BuscarporPlaca(string Placa)
        {
            foreach (var item in vehiculos)
            {
                if (item.placa == Placa)
                {
                    return item;
                }
            }
            return null;
        }

        public string Guardar(Vehiculo vehiculo)
        {
            if (BuscarporPlaca(vehiculo.placa) != null)
            {
                return $"El vehiculo seleccionado existe con esta ID:  {vehiculo.placa}";
            }
            var estado = repositorioVehicular.Guardar(vehiculo);

            Refresh();

            return estado ? $"el vehiculo se agrego correctamente con la placa:  {vehiculo.placa}" :
                                 $"ERROR al Guardar el vehiculo con la placa:  {vehiculo.placa}";
        }
    }
}
