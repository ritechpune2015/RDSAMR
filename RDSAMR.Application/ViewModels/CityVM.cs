using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RDSAMR.Application.ViewModels
{
    public class CityVM
    {
        public Int64 CityID { get; set; }
        [Required(ErrorMessage = "City Name Required")]
        public string CityName { get; set; }
        public Int64 StateID { get; set; }
        public string StateName { get; set; }

    }
}
