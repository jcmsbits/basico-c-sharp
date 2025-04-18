// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var radio = 0d; // Manera correcta de inicializar las variables de tipo doubel
var resultado = 0d;

const double Pi = 3.14; // El nombre de las variables constantes empieza con mayúscula

Console.WriteLine("Bienvenido, calculemos círculos");
// Pi * radio * radio
Console.WriteLine("Ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * radio * radio;

Console.WriteLine("El área de tu círculo es de: " + resultado);