using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set;  }
        public abstract string SalvarElMundo();

        public virtual string SalvarLaTierra() // Con virtual se puede hacer polimorfismo
                                               // al sobreescribir la funcion en la clase hija
                                               // con override
        {
            return $"{Nombre} ha salvado la tierra";
        }
    }
}
