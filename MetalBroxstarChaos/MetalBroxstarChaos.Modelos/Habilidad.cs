using System.ComponentModel.DataAnnotations;

namespace MetalBroxstarChaos.Modelos
{
    public class Habilidad
    {

        [Key]
        public int idHabilidad { get; set; }
        public int idPersonaje { get; set; }
        public string nombreHabilidad { get; set; }
        public int poder { get; set; }
    }
}
