using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelos
{
    // Perro implementa la interface IAnimal (perro cumple el contrato IAnimal)
    internal class Perro : IAnimal,IMascota
    {
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public int Peso { set; get; }
        public bool Muerde { set; get; }

        public Perro()
        {
        }

        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        public Perro(string nombre, int edad, int peso, bool muerde)
        {
            Nombre = nombre;
            Edad = edad;
            Peso = peso;
            Muerde = muerde;
        }
    }
}
