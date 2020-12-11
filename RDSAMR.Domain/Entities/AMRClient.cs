using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RDSAMR.Domain.Entities
{

    [Table("AMRClientTbl")]
    public class AMRClient:BaseEntity
    {
        [Key]
        public Int64 AMRClientID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Int64 CityID { get; set; }
        public string ContractPersonName { get; set; }

    }
}
