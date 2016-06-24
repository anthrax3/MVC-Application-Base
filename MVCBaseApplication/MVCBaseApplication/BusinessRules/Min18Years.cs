using MVCBaseApplication.Models;
using MVCBaseApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBaseApplication.BusinessRules
{
    public class Min18Years : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (RegisterViewModel)validationContext.ObjectInstance;

            if (user.BirthDay == null) return new ValidationResult("Birthday is required");

            var age = DateTime.Today.Year - user.BirthDay.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("You must be 18 or over to use this application");


        }
    }
}