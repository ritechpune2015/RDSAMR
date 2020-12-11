using System;
using System.Collections.Generic;
using System.Text;

namespace RDSAMR.Domain.Entities
{
    public class BaseEntity
    {
        public Nullable<long> CreatedByID { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<long> UpdatedByID { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Nullable<System.DateTime> DeletionDate { get; set; }
        public Nullable<long> DeletedByID { get; set; }
    }
}
