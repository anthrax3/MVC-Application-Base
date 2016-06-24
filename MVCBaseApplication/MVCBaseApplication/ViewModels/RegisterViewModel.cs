using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBaseApplication.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [MaxLength(15, ErrorMessage = "First Name cannot be longer than 15 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [MaxLength(15, ErrorMessage = "Last Name cannot be longer than 15 characters.")]
        public string LastName { get; set; }

       // public int Age { get; set; }

        public string Address { get; set; }
        public string PostCode { get; set; }
        //public string Hobbies { get; set; }
  
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}