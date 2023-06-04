using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente: Persona
    {
        public string Servicio { get; set; }
        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.fechaNacimiento = "";
            this.Servicio = "";
            this.nombreUsuario = "";
            this.contrasenia = "";
            this.cargo = "";
        }
    }
}
