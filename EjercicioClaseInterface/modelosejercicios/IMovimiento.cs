using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseInterface.modelosejercicios
{
    internal interface IMovimiento
    {
        int Numero { set; get; }
        string Fecha { set; get; }
        int Monto { set; get; }
        string Cliente { set; get; }
    }
}
