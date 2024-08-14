using System.ComponentModel.DataAnnotations;

namespace Odev_6_MVC.Models
{
    public class Araba
    {
        [Required(ErrorMessage = "Marka bilgisi zorunludur")]
        public string Marka { get; set; }

        [Required(ErrorMessage = "Model bilgisi zorunludur")]
        public string Model { get; set; }
    }
}
