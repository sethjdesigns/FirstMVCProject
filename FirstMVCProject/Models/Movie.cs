using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FirstMVCProject.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genre:")]
        public string Genre { get; set; }
        [Display(Name = "Price:")]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

    }

    public class MovieDBContext : DbContext 
    {
        public DbSet<Movie> Movies { get; set; }
    }
}