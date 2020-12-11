using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RDSAMR.Application.ViewModels
{
    public class RoleVM
    {
        public Int64 RoleID { get; set; }
        [Required(ErrorMessage ="Role Name Required")]
        public string RoleName { get; set; }
    }
}
