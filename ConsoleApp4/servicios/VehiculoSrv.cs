using ConsoleApp4.modelosvehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.servicios
{
    internal class VehiculoSrv
    {
        public static void Mostrar(IVehiculo vehiculo)
        {
            Console.WriteLine($"{vehiculo.Patente} {vehiculo.Dueño}");
        }
        public static double ObtenerPrecioSeguro(IVehiculo vehiculo)
        {
            // años x precio / 10
            // operaciones con entero devuelven un entero.
            return vehiculo.Año * vehiculo.Precio / 35; //   precio: 17142857
            // 4 x 150000000 / 35  = 1.714.285,714285714

        }
    }
}
