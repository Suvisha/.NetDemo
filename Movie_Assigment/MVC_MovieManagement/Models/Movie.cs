using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_MovieManagement.Models
{
    public class Movie
    {
        [Display(Name = "Id")]
        public int MovieId { get; set; }
 
        [Required(ErrorMessage = " Name is required.")]
        public string MovieName { get; set; }
 
        [Required(ErrorMessage = "Details is required.")]
        public string MovieDetails { get; set; }
    }
    
}