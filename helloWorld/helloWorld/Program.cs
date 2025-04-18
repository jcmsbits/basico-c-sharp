// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Programa que calcula el area de un rectangulo

// int ladoA; // Declaracion de variables
// int ladoB; // Como C sharp es de fuerte tipado, al introducir un valor flotante da error
// int resultado; // Por tanto es mejor usar variables de tipo double 
// double ladoA; // Aquí estamos declarando las variables de forma explícita
// double ladoB;
// double resultado;
// Con var declaramos las variables de forma implícitas
// Pero hay que asignarle un valor cuando de se declara

var ladoA = 1.1;
var ladoB = 1.1;
var resultado = 1.1;


Console.WriteLine("Calcula el área de un rectángulo");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;

Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + resultado);