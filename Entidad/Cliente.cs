using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente: Persona
    {

        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.fechaNacimiento = "";
            this.nombreUsuario = "";
            this.contrasenia = "";
            this.cargo = "";
        }
    }
}
