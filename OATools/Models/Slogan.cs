using System.ComponentModel.DataAnnotations;

namespace OATools.Models
{
    public class Slogan
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Slogan Text")]
        public string SloganText { get; set; }

        [Display(Name = "Slogan's Affiliated Program")]
        public string AffiliatedProgram { get; set; }
    }
}