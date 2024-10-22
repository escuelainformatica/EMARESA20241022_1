using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.modelos
{
    // no se escribe los alcances: public, private, etc.
    // los metodos no tienen codigo (sin implementacion)
    // no se escriben campos (pero si propiedades)

    // la interface conceptualmente es un contrato.
    // la interface no crea dependencia.
    // las clases pueden cumplir una o varias interfaces.
    internal interface IAnimal
    {
        string Nombre { set; get; }
        int Edad { set; get; }
        int Peso { set; get; }
    }
}
