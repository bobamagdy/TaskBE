using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBE.Dtos
{
    public class CreateUpdateDemographicTypeDto
    {
        [Key]
        public int DemTypeId { get; set; }
        [Required, StringLength(150)]
        public string TypeDescAr { get; set; }
        [StringLength(150)]
        public string TypeDescEn { get; set; }
    }
}
