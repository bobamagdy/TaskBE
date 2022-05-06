using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskBE.Dtos;
using TaskBE.Entities;

namespace TaskBE.EntityFrameWork.IRepository
{
    public interface IDemographicTypeRepository
    {
        Task<CreateUpdateDto> AddUpdatelist(CreateUpdateDto createUpdateDto);
        Task<DemographicTypeTbl> AddDemographicTypeAsync(CreateUpdateDemographicTypeDto input);
        Task<DemographicTypeTbl> EditDemographicTypeAsync(CreateUpdateDemographicTypeDto model);
        Task<IEnumerable<DemographicTypeTbl>> GetAllDemographicTypes();
        Task<DemographicTypeTbl> GetAsync(int id);
        Task<DemographicTypeTbl> DeleteAsync(int id);

    }
}
