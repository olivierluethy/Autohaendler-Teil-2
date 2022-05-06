using System.ComponentModel.DataAnnotations;

namespace Autohaendler.Models
{
    public class Autoverkaeufe
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Datum")]
        [Required(ErrorMessage ="{0} ist Pflichtfeld")]
        public DateTime Datum { get; set; }
        [Display(Name ="Anzahl")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public int Anzahl { get; set; }
        [Display(Name = "Preis")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public float Preis { get; set; }
    }
}
