using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelosvehiculos
{
    internal interface IVehiculo
    {
        string Patente { set; get; }
        string Dueño { set; get; }
        int Año { set; get; }
        int Precio { set; get; }
    }
}
