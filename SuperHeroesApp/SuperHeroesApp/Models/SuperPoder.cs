using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperPoder // Si un proyecto diferente a SuperHeoresApp hace referencia
                              // a esta clase, no tendrá acceso por el modificador de acceso internal
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;
    }
}
