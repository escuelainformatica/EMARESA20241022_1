using ConsoleApp4.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.servicios
{
    internal class AnimalSrv
    {
        public static void Mostrar(IAnimal animal)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Nombre: {animal.Nombre}");
            Console.WriteLine($"Edad: {animal.Edad}");
            Console.WriteLine($"Peso: {animal.Peso}");            
            Console.WriteLine("------------------------------------");
        }
    }
}
