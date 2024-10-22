using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseInterface.modelosejercicios
{
    internal interface IPersona
    {
        string Nombre { set; get; }
        string Apellido { set; get; }
        string Rut { set; get; }
        string Direccion { set; get; }
        string Correo { set; get; }
    }
}
