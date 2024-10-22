using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelosvehiculos
{
    internal class Camioneta : IVehiculo
    {
        public string Patente { set; get; }
        public string Dueño { set; get; }
        public int Año { set; get; }
        public int Precio { set; get; }
        public bool FourxFour { set; get; }
        public int PesoMaximo { set; get; }
    }
}
