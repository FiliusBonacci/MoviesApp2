using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using SelectListItem = System.Web.Mvc.SelectListItem;

namespace MoviesApp2.ViewModels
{
    public class EditMovieViewModels
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Długość nie może być większa niż 100 znaków.")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}