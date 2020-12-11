using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{
    [Table("StateTbl")]
    public class State : BaseEntity
    {
        [Key]
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public Int64 CountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual IEnumerable<City> City { get; set; }
    }
}
