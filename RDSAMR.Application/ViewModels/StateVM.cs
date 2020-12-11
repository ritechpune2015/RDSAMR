using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RDSAMR.Application.ViewModels
{
    public class StateVM
    {
        public Int64 StateID { get; set; }
        [Required(ErrorMessage = "State Name Required")]
        public string StateName { get; set; }
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }

    }
}
