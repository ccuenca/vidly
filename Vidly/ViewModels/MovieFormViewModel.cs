using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        [Required]
        public int? Id { get; set; }

        [Required]
        [StringLength((500))]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }


        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        [Display(Name = "Number In Stock")]
        public int? NumberInStock { get; set; }

        
        public string Title => Id != 0 ? "Edit Movie" : "New Movie";

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
            ReleaseDate = movie.ReleaseDate;
            DateAdded = movie.DateAdded;
        }


        //public string Title
        //{
        //    get
        //    {
        //        return Id != 0 ? "Edit Movie" : "New Movie";
        //    }
        //}
    }
}