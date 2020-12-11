using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{
    [Table("RoleTbl")]
    public class Role : BaseEntity
    {
        [Key]
       
        public Int64 RoleID { get; set; }
      
        public string RoleName { get; set; }
    }
}
