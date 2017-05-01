using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class Receipt
    {
        public int id { get; set;}
        [Required]
        public string products { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string city { get; set; }

        public double totalPrice{get; set;}

    }
}