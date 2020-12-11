using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{
    [Table("CountryTbl")]
    public class Country : BaseEntity
    {

        [Key]
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }
        public virtual IEnumerable<State> States { get; set; }
    }
}
