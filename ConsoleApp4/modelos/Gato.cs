using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelos
{
    // Gato hereda de Animal.  <-- buena
    // Gato <depende> de la clase Animal <-- no es buena.
    internal class Gato : IAnimal
    {
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public int Peso { set; get; }
        public Gato()
        {
        }

        public Gato(string nombre, int edad, int peso)
        {
            Nombre = nombre;
            Edad = edad;
            Peso = peso;
        }
    }
}
