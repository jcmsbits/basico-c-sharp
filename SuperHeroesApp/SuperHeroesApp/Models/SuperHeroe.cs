using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp.Models
{
    internal class SuperHeroe : Heroe, ISuperHeroe
    {
        public int Id { get; set; } = 1; //  También se puede inicializar las variables al declararlas en la clase
        private string _Nombre;
        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public override string Nombre
        {
            get
            {
                return _Nombre;
             }
            set
            {
                _Nombre = value.Trim(); 
            }
        }

        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }

        public SuperHeroe() // En C sharp el constructor se llama igual que la clase
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta  usando el super poder {item.Nombre}!!");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }
        public override string SalvarLaTierra()
        {
            // return base.SalvarLaTierra(); // base se refiere al padre
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }

    }   
   
}
