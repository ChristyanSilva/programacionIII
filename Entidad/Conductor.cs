using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Conductor:Persona
    {
        public int aniosdeExperiencia { get; set; }
        public Conductor()
        {
            this.nombre="" ;
            this.apellido = "";
            this.fechaNacimiento = "";
            this.aniosdeExperiencia= 0;
        }
    }
}
