using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Model
{
    public class InputValues
    {
        [Required]
        public int valueA { get; set; }

        [Required]
        public int ValueB { get; set; }
      

    }
}
