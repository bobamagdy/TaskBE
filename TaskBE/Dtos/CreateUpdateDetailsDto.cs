using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskBE.Entities;

namespace TaskBE.Dtos
{
    public class CreateUpdateDetailsDto
    {
        public CreateUpdateDetailsDto()
        {
            AddList = new List<DemographicTypeDTLTbl>();
            UpdateList = new List<DemographicTypeDTLTbl>();
        }
        public List<DemographicTypeDTLTbl> AddList { get; set; }
        public List<DemographicTypeDTLTbl> UpdateList { get; set; }
    }
}
