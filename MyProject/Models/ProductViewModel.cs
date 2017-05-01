using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class ProductViewModel
    {
        [Range(0,100)]
        public double AmountOfJuice { get; set; }
        [Range(0, 100)]
        public double AmountOfBread { get; set; }
    }
}
