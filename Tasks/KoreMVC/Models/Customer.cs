using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;  // TO BE ADDED MANUALLY TO ACCESS DIFF DATA ATTRIBUTES

namespace KoreMVC.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        //System.ComponentModel.DataAnnotations is required for avoiding ambiguity
        public string ? CustomerName { get; set; }
        public string ? Number { get; set; }
        public string? City { get; set; }

        public string? Gender { get; set; }

    }
}
