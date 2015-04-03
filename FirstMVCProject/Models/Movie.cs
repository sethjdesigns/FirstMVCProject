using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FirstMVCProject.Models
{

    public enum RatingsEnum
    {
        G,
        PG,
        PG13,
        R  
    }

    public class Movie
    {
        public RatingsEnum RatingsEnum;
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "Release Date:"),DataType(DataType.Date),DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genre:"),RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"),Required,StringLength(30)]
        public string Genre { get; set; }
        [Display(Name = "Price:"),DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false),Range(1, 100),DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Rating:"),RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"),StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext 
    {
        public DbSet<Movie> Movies { get; set; }
    }
}