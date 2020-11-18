using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OATools.Models
{
    public class Prayer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PrayerText { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}