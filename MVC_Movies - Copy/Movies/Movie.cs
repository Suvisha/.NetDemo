//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movies
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Movie
    {

        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please Enter Movie Name")]
        [Display(Name = "Enter Movie Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Name must be between 3 and 50 characters!")]
        public string MovieName { get; set; }
       
        [Required(ErrorMessage = "Please Enter Movie Details")]
        [Display(Name = "Enter Movie Details")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Details must be between 3 and 50 characters!")]
        public string MovieDetails { get; set; }
    }
}