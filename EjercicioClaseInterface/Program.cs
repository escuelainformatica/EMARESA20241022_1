using EjercicioClaseInterface.modelosejercicios;
using EjercicioClaseInterface.servicios;

var empleado = new Empleado
{
    Nombre = "John",
    Apellido = "Doe"
};
var cliente = new Cliente
{
    Nombre = "Anna",
    Apellido = "Smith"
};

PersonaServicio.Mostrar(empleado);
PersonaServicio.Mostrar(cliente);

var fac = new Factura();
var nc = new NotaCredito();
var nd = new NotaDebito();
