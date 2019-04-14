using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebMVCcap04.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage ="Ingrese el título de la película")]
        [Display(Name ="Título")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Ingrese la fecha de lanzamiento")]
        [Display(Name = "Fecha de lanzamiento")]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage ="Ingrese el género de la película")]
        [Display(Name ="Género")]
        public string Genre { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [StringLength(5)]
        [Required(ErrorMessage ="Ingrese el rating")]
        public string Rating { get; set; }
    }
}