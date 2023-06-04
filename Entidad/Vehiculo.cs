using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Vehiculo
    {
        public string marca { get; set; } //deletear
        public string placa { get; set; }
        public double aniosdeUso { get; set; }
        public string tipoGasolina { get; set; }
        public double kilometraje { get; set; }
        public string estadodelVehiculo { get; set; }
        public int idConductorAsignado { get; set; }

        public Vehiculo()
        {
            this.marca = "";
            this.placa = "";
            this.aniosdeUso= 0.0;
            this.tipoGasolina = "";
            this.kilometraje= 0.0;
            this.estadodelVehiculo = "";
            this.idConductorAsignado = 0;
        }        
    }
}
