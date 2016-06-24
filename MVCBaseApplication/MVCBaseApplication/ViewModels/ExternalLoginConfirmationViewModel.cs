using MVCBaseApplication.BusinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBaseApplication.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [MaxLength(15, ErrorMessage = "First Name cannot be longer than 15 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [MaxLength(15, ErrorMessage = "Last Name cannot be longer than 15 characters.")]
        public string LastName { get; set; }

        [Display(Name = "BirthDay")]
        //[Min18Years]
        public DateTime? BirthDay { get; set; }

        public string Address { get; set; }
        public string PostCode { get; set; }
        
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}