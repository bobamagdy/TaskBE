using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBE.Entities
{
    [Table("DemographicTypeTbl")]
    public class DemographicTypeTbl
    {
        [Key]
        public int DemTypeId { get; set; }
        [Required, StringLength(150)]
        public string TypeDescAr { get; set; }
        [StringLength(150)]
        public string TypeDescEn { get; set; }
        public List<DemographicTypeDTLTbl> demographicTypeDTLTbls { get; set; }
    }
}
