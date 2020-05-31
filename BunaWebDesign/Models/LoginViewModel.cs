using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BunaWebDesign.Models
{

    // for checking validations
    public class LoginViewModel
    {

       
          [Required(ErrorMessage = "Please Enter UserName")]
         public string UserName { get; set; }
          
           
       
         [Required(ErrorMessage = "Please Enter Email")]
         [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email is not valid")]
         public string EmailId { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
         public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
         public string Address { get; set; }
    }
}