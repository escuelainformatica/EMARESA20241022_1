using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseInterface.modelosejercicios
{
    internal class Empleado : IPersona
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Rut { set; get; }
        public string Direccion { set; get; }
        public string Correo { set; get; }
    }
}
