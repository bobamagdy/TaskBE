using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBE.Entities
{
    [Table("DemographicTypeDTLTbl")]
    public class DemographicTypeDTLTbl
    {
        [Key]
        public int DemTypeDTL_ID { get; set; }
        public int DemTypeID { get; set; }
        [Required, StringLength(150)]
        public string ChoicesAr { get; set; }
        [StringLength(150)]
        public string ChoicesEn { get; set; }
        [Required]
        public int WeightValue { get; set; }
        [ForeignKey("DemTypeID")]
        public DemographicTypeTbl DemographicTypeTbl { get          ; set; }

    }
}
