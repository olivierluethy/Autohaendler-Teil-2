using System.ComponentModel.DataAnnotations;

namespace Autohaendler.Models
{
    public class Auto
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Hersteller")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public string Hersteller { get; set; }
        [Display(Name = "Modell")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public string Modell { get; set; }
        [Display(Name = "Farbe")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public string Farbe { get; set; }
        [Display(Name ="Preis")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public float Preis { get; set; }
    }
}
