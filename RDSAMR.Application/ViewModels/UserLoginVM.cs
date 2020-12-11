using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RDSAMR.Application.ViewModels
{
    public class UserLoginVM
    {
        [Required(ErrorMessage ="Email ID Required")]
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
