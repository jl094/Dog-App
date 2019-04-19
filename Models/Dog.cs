using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogApp.Models
{
    public class Dog
    {
        public int Id { get; set; }
        [Required]
        public string Breed { get; set; }
        public string SubBreed { get; set; }
    }
}