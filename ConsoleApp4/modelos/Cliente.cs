using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelos
{
    internal class Cliente
    {
        // esto es un campo
        public string nombre;
        // esto es una propiedad
        public string Apellido { set; get; }

        // la propiedad hace lo mismo que el campo pero se considera una funcion.
        // las propiedades se pueden cambiar las lecturas (get) y escrituras (set)


    }
}
