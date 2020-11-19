using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OATools.Models
{
    public class FreePdfLink
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}