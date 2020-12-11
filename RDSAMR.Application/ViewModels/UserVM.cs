using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RDSAMR.Application.ViewModels
{
    public class UserVM
    {

        public Int64 UserID { get; set; }
        [Required(ErrorMessage ="User Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage ="EmailID Required")]
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Mobile No Required")]
        public string MobileNo { get; set; }
    }
}
