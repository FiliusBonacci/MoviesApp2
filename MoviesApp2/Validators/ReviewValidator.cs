using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MoviesApp2.Models;

namespace MoviesApp2.Validators
{
    public class ReviewValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Review review = (Review)validationContext.ObjectInstance;

            if (review.Grade < 1 || review.Grade > 6)
            {
                return new ValidationResult("ocena nie wpada do przedziału (0,6)");
            }

            return ValidationResult.Success;
        }
    }
}