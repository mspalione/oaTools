using System;
using System.ComponentModel.DataAnnotations;

namespace OATools.Models
{
    public class TimedBitchLetter
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Do Your B*tching")]
        public string Bitching { get; set; }

        [Display(Name = "God's Response")]
        public string GodsResponse { get; set; }
    }
}