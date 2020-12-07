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
        public string Bitching { get; set; }
        public string GodsResponse { get; set; }
    }
}