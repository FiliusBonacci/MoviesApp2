﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesApp2.Models;

namespace MoviesApp2.Models
{
    public class Category : IEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}