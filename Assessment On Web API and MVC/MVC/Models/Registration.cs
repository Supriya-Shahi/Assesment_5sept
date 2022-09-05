using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Registration
    {
        [Required(ErrorMessage ="ID Required")]
        [StringLength(20,MinimumLength =5)]
        public string ID { get; set; }

        [Required(ErrorMessage = "UserName Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [StringLength(20,MinimumLength =8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Required")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        [Compare("Password",ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email Address Required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "City Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only Alphabets are allowed")]
        public string City { get; set; }
    }
}