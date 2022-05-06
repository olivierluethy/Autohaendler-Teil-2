using System.ComponentModel.DataAnnotations;

namespace Autohaendler.Models
{
    public class Hersteller
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public string Name { get; set; }
        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public string Adresse { get; set; }
        [Display(Name = "Telefonnummer")]
        [Required(ErrorMessage = "{0} ist Pflichtfeld")]
        public string Telefonnummer { get; set; }
    }
}
