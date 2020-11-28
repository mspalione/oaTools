using System;
using System.ComponentModel.DataAnnotations;

namespace OATools.Models
{
    public class Gratitude
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Gratitude #1")]
        public string Grat1 { get; set; }

        [Display(Name = "Gratitude #2")]
        public string Grat2 { get; set; }

        [Display(Name = "Gratitude #3")]
        public string Grat3 { get; set; }

        [Display(Name = "Gratitude #4")]
        public string Grat4 { get; set; }

        [Display(Name = "Gratitude #5")]
        public string Grat5 { get; set; }

        [Display(Name = "Gratitude #6")]
        public string Grat6 { get; set; }

        [Display(Name = "Gratitude #7")]
        public string Grat7 { get; set; }

        [Display(Name = "Gratitude #8")]
        public string Grat8 { get; set; }

        [Display(Name = "Gratitude #9")]
        public string Grat9 { get; set; }

        [Display(Name = "Gratitude #10")]
        public string Grat10 { get; set; }
    }
}