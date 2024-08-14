using System.ComponentModel.DataAnnotations;

namespace Odev_6_MVC.Models
{
    public class Ogrenci
    {
        [Required(ErrorMessage = "Öğrencinin adı bilgisi zorunludur")]
        public string Adi { get; set; }

        [Required(ErrorMessage = "Öğrencinin soyadı bilgisi zorunludur")]
        public string Soyadi { get; set; }

        [Required(ErrorMessage = "Öğrencinin bölüm bilgisi zorunludur")]
        public string Bolum { get; set; }
    }
}
