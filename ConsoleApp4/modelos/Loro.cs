using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelos
{
    internal class Loro : IAnimal
    {
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public int Peso { set; get; }
    }
}
