using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assessment_review.Models.TempConverter
{
    public class FormResultViewModel
    {
        [Display(Name = "Farenheit")]
        public double F { get; set; }

        [Display(Name = "Celcius")]
        public double C => (F - 32) * 5 / 9;
    }
}
