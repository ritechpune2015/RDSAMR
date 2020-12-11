using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{
    [Table("UserTbl")]
    public class User : BaseEntity
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 UserID { get; set; }
     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
   
        public string EmailID { get; set; }
     
        public string MobileNo { get; set; }
        public string PasswordHash { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
