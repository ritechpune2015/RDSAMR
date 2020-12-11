using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{

    [Table("SuperAdminTbl")]
    public class SuperAdmin
    {
        [Key]
        public Int64 SuperAdminID { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string PasswordHash { get; set; }
    }
}
