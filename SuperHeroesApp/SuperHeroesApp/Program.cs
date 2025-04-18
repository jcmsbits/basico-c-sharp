// See https://aka.ms/new-console-template for more information

using SuperHeroesApp;
using SuperHeroesApp.Models;
using System.Text;

var imprimitInfo = new ImprimirInfo();




var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;
var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Nivel = NivelPoder.NivelTres;
var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

imprimitInfo.ImprimirSuperHeroe(superman);
imprimitInfo.ImprimirSuperHeroe(wolverine);


SuperHeroRecord superHeroRecord = new(1, "Superman", "Clark Kent"); // Otra manera de crear instancias
SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");

//Los records con los mismos valores comparten el mismo espacio en memoria?! 
Console.WriteLine(superHeroRecord == superHeroRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
string resultSalvarMundo = superman.SalvarElMundo();
string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSuperPoderes); 
Console.WriteLine(resultSalvarMundo);
Console.WriteLine(resultSalvarTierra);



List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(superFuerza);
poderesWolverine.Add(regeneracion);
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiheroe = wolverine.RealizarAccionDeAntiHeroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);



enum NivelPoder
{ 
    NivelUno, 
    NivelDos, 
    NivelTres
}

public record SuperHeroRecord(int Id, string Nombre, string Identidad);