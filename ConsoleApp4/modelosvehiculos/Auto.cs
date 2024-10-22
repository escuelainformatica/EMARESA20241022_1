using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelosvehiculos
{
    internal class Auto : IVehiculo
    {
        public string Patente { set; get; }
        public string Dueño { set; get; }
        public int Año { set; get; }
        public int Precio { set; get; }
    }
}
