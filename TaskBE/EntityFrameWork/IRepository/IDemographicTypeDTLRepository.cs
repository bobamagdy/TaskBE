using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskBE.Dtos;
using TaskBE.Entities;

namespace TaskBE.EntityFrameWork.IRepository
{
    public interface IDemographicTypeDTLRepository
    {
        Task<CreateUpdateDetailsDto> AddUpdatelist(CreateUpdateDetailsDto createUpdateDto);

        Task<DemographicTypeDTLTbl> AddDemographicTypeDTLAsync(CreateUpdateDemographicTypeDTLDto input);
        Task<DemographicTypeDTLTbl> EditDemographicTypeDTLAsync(CreateUpdateDemographicTypeDTLDto input);
        Task<IEnumerable<DemographicTypeDTLTbl>> GetAllDemographicTypeDTLs();
        Task<DemographicTypeDTLTbl> GetAsync(int id);
        Task<DemographicTypeDTLTbl> DeleteAsync(int id);
    }
}
