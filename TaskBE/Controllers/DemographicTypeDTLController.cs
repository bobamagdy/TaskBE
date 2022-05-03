using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskBE.Dtos;
using TaskBE.Entities;
using TaskBE.EntityFrameWork.IRepository;

namespace TaskBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemographicTypeDTLController : ControllerBase
    {
        private readonly IDemographicTypeDTLRepository _demographicTypeDTLRepository;

        public DemographicTypeDTLController(IDemographicTypeDTLRepository demographicTypeDTLRepository)
        {
            _demographicTypeDTLRepository = demographicTypeDTLRepository;
        }

        [HttpGet]
        [Route("GetAllDemographicTypeDTLs")]
        public async Task<IEnumerable<DemographicTypeDTLTbl>> GetAllDemographicTypeDTLs()
        {
            var demographicTypeDTL = await _demographicTypeDTLRepository.GetAllDemographicTypeDTLs();
            if (demographicTypeDTL == null)
            {
                return null;
            }
            return demographicTypeDTL;
        }


        [HttpGet]
        [Route("GetDemographicTypeDTLData/{id}")]
        public async Task<DemographicTypeDTLTbl> GetDemographicTypeDTLData(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var demographicTypeDTL = await _demographicTypeDTLRepository.GetAsync(id);
            if (demographicTypeDTL != null)
            {
                return demographicTypeDTL;
            }
            return null;
        }


        [HttpDelete]
        [Route("DeleteDemographicTypeDTL/{id}")]
        public async Task<DemographicTypeDTLTbl> DeleteDemographicTypeDTL(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var demographicTypeDTL = await _demographicTypeDTLRepository.DeleteAsync(id);
            if (demographicTypeDTL != null)
            {
                return demographicTypeDTL;
            }
            return null;
        }


        [HttpPost]
        [Route("AddNewDemographicTypeDTL")]
        public async Task<DemographicTypeDTLTbl> AddNewDemographicTypeDTL(createUpdateDemographicTypeDTLDto input)
        {
            if (ModelState.IsValid)
            {
                var demographicTypeDTL = await _demographicTypeDTLRepository.AddDemographicTypeDTLAsync(input);
                if (demographicTypeDTL != null)
                {
                    return demographicTypeDTL;
                }

            }
            return null;
        }


        [HttpPut]
        [Route("EditDemographicTypeDTL")]
        public async Task<DemographicTypeDTLTbl> EditDemographicTypeDTL(createUpdateDemographicTypeDTLDto input)
        {
            if (input == null)
            {
                return null;
            }
            var demographicTypeDTL = await _demographicTypeDTLRepository.EditDemographicTypeDTLAsync(input);
            if (demographicTypeDTL != null)
            {
                return demographicTypeDTL;
            }
            return null;
        }
    }
}

