// See https://aka.ms/new-console-template for more information

// bool valorA = true;
// bool valorB = false;
// bool valorC = true;

// & ("Y")
// || ("OR")
// ! ("NOT")
// ^ ("XOR")
var (valorA, valorB, valorC) = (true, false, true);
Console.WriteLine("Valor A: " + valorA + " Valor B: " + valorB + " Valor C " + valorC);

var resultAnd = valorA && valorB;
Console.WriteLine("Valor de A y Valor de B: " + resultAnd);

bool resultOr = valorA ||  valorB;

Console.WriteLine("Valor de A o Valor B: " +  resultOr);

bool resultAndOr = (valorA && valorB) || valorC;

Console.WriteLine("Valor de A y Valor de B, resultado o Valor C: " + resultAndOr);

bool resultOrOr = valorA || valorB || valorC;

Console.WriteLine("Valor A o Valor B o Valor C " + resultOrOr);

bool resultNot = !valorA;

Console.WriteLine("Negación del valor: ", resultNot);

bool resultXor = valorA ^ valorB;
Console.WriteLine("El Valor A es diferente al Valor de B: " + resultXor);

bool resultXorAnidado = valorA ^ valorB ^ valorC;
Console.WriteLine("El Valor A es diferente al Valor de B, resultado es diferente al Valor C:  " + resultXorAnidado);