// See https://aka.ms/new-console-template for more information

int totalJugador = 25;
int totalDealer = 15;
int num = 0;
int platziCoins = 0;
string message = "";
string switchControl = "menu";
string controlOtraCarta = "";
System.Random random = new System.Random();

// Blackjack, juntar 21 pidiendo, en caso de pasarte de 21 pierdes.
// cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer

while (true)
{
    Console.WriteLine("Welcome al P L A T Z I N O");
    Console.WriteLine("Cuántos PlatziCoins deseas?\n" + 
                      "Ingresa un número entero\n" + 
                      "Recuerda que necesitas una por ronda.");
    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
        { 
            totalJugador = 0;
            totalDealer = 0;
            switch (switchControl)
            {
  
                case "menu":
                    Console.WriteLine("Welcome al c a s i n o");
                    Console.WriteLine("Escriba el '21' para jugar al 21");
                    switchControl = Console.ReadLine();
                    i--;
                    break;

                case "21":
                    do
                    {           
                        num = random.Next(1, 12);
                        totalJugador = totalJugador + num;
                        Console.WriteLine("Toma tu carta jugador");
                        Console.WriteLine($"Te salio el número: {num} ");
                        Console.WriteLine("Deseas otra carta?");
                        controlOtraCarta = Console.ReadLine();
                    }
                    while (
                           controlOtraCarta == "Si"  ||
                           controlOtraCarta == "si"  ||
                           controlOtraCarta == "yes" 
                    );
        
                    totalDealer = random.Next(14, 23);
                    Console.WriteLine($"El dealer tiene: {totalDealer}");

                    if (totalJugador > totalDealer && totalJugador < 22)
                    {
                        message = "Venciste al dealer, felicidades";
                        switchControl = "menu";
                    }
                    else if (totalJugador >= 22)
                    {
                        message = "Perdiste vs el dealer, te pasaste de 21";
                        switchControl = "menu";
                    }
                    else if (totalJugador <= totalDealer)
                    {
                        message = "Perdiste vs el dealer, lo siento";
                        switchControl = "menu";
                    }
                    else
                    {
                        message = "Condición no válida";
                        switchControl = "menu";
                    }
                    Console.WriteLine(message);
                    break;
        }
    }
}

