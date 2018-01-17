using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp2.Models
{
    public class Tag : IEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}