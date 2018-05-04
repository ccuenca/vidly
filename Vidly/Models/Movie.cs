using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength((500))]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20, ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        [Required]
        public int NumberAvailable { get; set; }

    }
}