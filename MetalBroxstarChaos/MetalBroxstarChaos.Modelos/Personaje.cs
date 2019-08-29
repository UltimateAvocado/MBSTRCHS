using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetalBroxstarChaos.Modelos
{
    public class Personaje
    {
        public Personaje()
        {
            Habilidades = new List<Habilidad>();
        }

        [Key]
        public int idPersonaje { get; set; }
        public string nombrePersonaje { get; set; }
        public int nivelPersonaje { get; set; }
        public int idClase  {get; set; }

            
        public List<Habilidad> Habilidades { get; set; }

        public Clase clase { get; set; }
    }
}
