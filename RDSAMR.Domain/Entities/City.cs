using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{
    [Table("CityTbl")]
    public class City :BaseEntity
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 CityID { get; set; }
        public string CityName { get; set; }
        public Int64 StateID { get; set; }
        public virtual State State { get; set; }
    }
}
