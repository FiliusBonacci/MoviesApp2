using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MoviesApp2.Validators;

namespace MoviesApp2.Models
{
    public class Review : IEntity
    {
        public string Comment { get; set; }
        [Range(0, 6, ErrorMessage = "Wartość musi znajdować się w przedziale [0,6]")]
        [ReviewValidator]
        public int Grade { get; set; }

        public int MovieId { get; set; }
        public string UserId { get; set; }

    }
}