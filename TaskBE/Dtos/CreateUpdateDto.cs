using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskBE.Entities;

namespace TaskBE.Dtos
{
    public class CreateUpdateDto
    {
        public CreateUpdateDto()
        {
            AddList = new List<DemographicTypeTbl>();
            UpdateList = new List<DemographicTypeTbl>();
        }
        public List<DemographicTypeTbl> AddList { get; set; }
        public List<DemographicTypeTbl> UpdateList { get; set; }
    }
}
