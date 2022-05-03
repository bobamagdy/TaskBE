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
        Task<DemographicTypeDTLTbl> AddDemographicTypeDTLAsync(createUpdateDemographicTypeDTLDto input);
        Task<DemographicTypeDTLTbl> EditDemographicTypeDTLAsync(createUpdateDemographicTypeDTLDto input);
        Task<IEnumerable<DemographicTypeDTLTbl>> GetAllDemographicTypeDTLs();
        Task<DemographicTypeDTLTbl> GetAsync(int id);
        Task<DemographicTypeDTLTbl> DeleteAsync(int id);
    }
}
