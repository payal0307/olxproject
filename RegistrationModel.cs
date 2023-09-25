using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OLXProject.Models
{
    public class RegistrationModel
    {

        [Display(Name = "userId")]
        public int userId { get; set; }

        [Required(ErrorMessage = "Please Enter FirstName")]
        [Display(Name = "firstName")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please Enter LastName")]
        [Display(Name = "lastName")]
        public string lastName { get; set; }

        [Remote("CheckEmail", "User", ErrorMessage = "Email already exists")]

        [Required]
        [RegularExpression("^[a-zA-Z0-9_-]+@([a-zA-Z0-9-]+)+[a-zA-Z]{2,6}$", ErrorMessage = "Email id is not valid")]
        public string userEmail { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^([a-zA-Z0-9@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 " +
        "UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "MobileNo")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^?([0−9]3)?([0−9]3)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string MobileNo { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please Select the gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "The Address field is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please select a city")]
        public string City { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "Please select a Role")]
        public string Role {get; set;}

            //[Required(ErrorMessage = "Please enter Security Answer")]
            //[Display(Name = "SecurityAnswer")]
            //public string SecurityAnswer { get; set; }

        }
}

