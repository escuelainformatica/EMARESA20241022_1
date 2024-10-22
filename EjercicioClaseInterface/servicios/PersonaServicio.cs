using EjercicioClaseInterface.modelosejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseInterface.servicios
{
    internal class PersonaServicio
    {
        public static void Mostrar(IPersona persona)
        {
            Console.WriteLine(persona.Nombre);
        }
    }
}
