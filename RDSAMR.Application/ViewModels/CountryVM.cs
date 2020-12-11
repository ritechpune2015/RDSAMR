using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RDSAMR.Application.ViewModels
{
    public class CountryVM
    {
        public Int64 CountryID { get; set; }
        [Required(ErrorMessage = "Country Name Required")]
        public string CountryName { get; set; }
        
    }
}
