using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{
    [Table("UserRoleTbl")]
    public class UserRole : BaseEntity
    {
        [Key]
        //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 UserRoleID { get; set; }
        public Int64 UserID { get; set; }
        public Int64 RoleID { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
