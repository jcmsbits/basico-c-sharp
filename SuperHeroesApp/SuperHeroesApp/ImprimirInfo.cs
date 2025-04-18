using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            Console.WriteLine($"IdentidadSecreta: {superHeroe.IdentidadSecreta}");

        }
    }
}
