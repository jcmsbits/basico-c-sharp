// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ricardo Pérez ID!");
int altura = 168;
int edad = 89;
string nombre = "Ricardo Perez";
string informacion = "Nació en Hidalgo, es estudiante de gastronomía y astronomía";
var hobby = "deportista";

string tarjetaDeIdentificacion = $"La información de {nombre} es la siguiente\n" +
    $"es la siguiente\nSu edad es {edad} años, su altura es {altura}, su hobby es: {hobby}";

Console.WriteLine(tarjetaDeIdentificacion);