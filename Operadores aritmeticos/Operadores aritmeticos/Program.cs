// See https://aka.ms/new-console-template for more information

var valorA = 0d;
var valorB = 0d;
var resultado = 0d;

Console.WriteLine("Ingrese el valor de A: ");
valorA = Convert.ToDouble(Console.ReadLine());

valorA++; // Incremento

Console.WriteLine("Ingrese el valor de B: ");
valorB = Convert.ToDouble(Console.ReadLine());
valorB--; // Decremento

var suma = valorA + valorB; // Suma
var resta = valorA - valorB;
var multiplicacion = valorA * valorB;
var division = valorA / valorB;
var resto = valorA % valorB;

Console.WriteLine("La suma es: " + suma);
Console.WriteLine("La resta es: " + resta);
Console.WriteLine("La multiplicación es: " + multiplicacion);
Console.WriteLine("La División es: " + division);
Console.WriteLine("El resto es: " + resto);




