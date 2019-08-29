using System.ComponentModel.DataAnnotations;

namespace MetalBroxstarChaos.Modelos
{
    public class Clase
    {

        [Key]
        public int idClase { get; set; }

        public string nombreClase { get; set; }
    }
}
