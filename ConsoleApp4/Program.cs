﻿// Ejercicio Tienda de mascota.
// 1) modelos: perro y gato
// 2) servicio: PerroSrv
using ConsoleApp4.modeloejercicio;
using ConsoleApp4.modelos;
using ConsoleApp4.modelosvehiculos;
using ConsoleApp4.servicios;

var snoopy = new Perro();
snoopy.Nombre = "Snoopy";
snoopy.Edad = 3;
snoopy.Peso = 5;
snoopy.Muerde = false;
var checkers = new Perro("checkers", 3, 5, false);
// autoconstructor
var lazzy = new Perro
{
    Nombre="Lazzy",
    Edad=4,
    Peso=7,
    Muerde=false
};
var perro = new Perro("Patan");


AnimalSrv.Mostrar(snoopy);
AnimalSrv.Mostrar(lazzy);

var garfield = new Gato("garfield", 7, 100);

AnimalSrv.Mostrar(garfield);

var loro = new Loro { Nombre = "Matias", Edad = 50, Peso = 1 };

AnimalSrv.Mostrar(loro);

IAnimal animal = new Perro(); // ok
Perro animal2 = new Perro(); // ok tambien

// ejercicio vehiculos
var auto1 = new Auto { Patente = "aabb20", Dueño = "john", Precio = 150000000, Año = 4 };

VehiculoSrv.Mostrar(auto1);
Console.WriteLine("precio:"+VehiculoSrv.ObtenerPrecioSeguro(auto1));

// Ejercicio en la clase
var cliente = new ConsoleApp4.modeloejercicio.Cliente
{
    Nombre = "John",
    Apellido = "Doe"
};
var empleado = new Empleado
{
    Nombre = "Anna",
    Apellido = "Smith"
};

PersonaServicio.Mostrar(cliente);
PersonaServicio.Mostrar(empleado);

var fac = new Factura
{
    Numero = 1,
    Cliente = "john",
    Fecha = "01/01/2010",
    Monto = 3333
};
var credito = new NotaCredito
{
    Numero = 44,
    Cliente = "john",
    Fecha = "01/01/2010",
    Monto = 3333
};
var debito = new NotaDebito
{
    Numero = 44,
    Cliente = "john",
    Fecha = "01/01/2010",
    Monto = 3333
};
