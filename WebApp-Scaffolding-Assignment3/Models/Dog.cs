using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Scaffolding_Assignment3.Models
{
    //creating the model class with properties
	public class Dog
	{
		[Required]
		public int Id { get; set; }
        [Required]
        public string? ScientificName { get; set; }
        [Required]
        public string? Breed { get; set; }        
        [Required]
        public string? Colour { get; set; }
        [Required]
        public decimal Height { get; set; }
        [Required]
        public decimal Weight { get; set; }
	}
}

