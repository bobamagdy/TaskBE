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
    public class DemographicTypeController : ControllerBase
    {
        private readonly IDemographicTypeRepository _demographicTypeRepository;

        public DemographicTypeController(IDemographicTypeRepository demographicTypeRepository)
        {
            _demographicTypeRepository = demographicTypeRepository;
        }

        [HttpGet]
        [Route("GetAllDemographicTypes")]
        public async Task<IEnumerable<DemographicTypeTbl>> GetAllDemographicTypes()
        {
            var demographicType = await _demographicTypeRepository.GetAllDemographicTypes();
            if (demographicType == null)
            {
                return null;
            }
            return demographicType;
        }


        [HttpGet]
        [Route("GetDemographicTypeData/{id}")]
        public async Task<DemographicTypeTbl> GetDemographicTypeData(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var demographicType = await _demographicTypeRepository.GetAsync(id);
            if (demographicType != null)
            {
                return demographicType;
            }
            return null;
        }


        [HttpDelete]
        [Route("DeleteDemographicType/{id}")]
        public async Task<DemographicTypeTbl> DeleteDemographicType(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var demographicType = await _demographicTypeRepository.DeleteAsync(id);
            if (demographicType!=null)
            {
                return demographicType;
            }
            return null;
        }


        [HttpPost]
        [Route("AddNewDemographicType")]
        public async Task<DemographicTypeTbl> AddNewDemographicType(CreateUpdateDemographicTypeDto input)
        {
            if (ModelState.IsValid)
            {
                var demographicType = await _demographicTypeRepository.AddDemographicTypeAsync(input);
                if (demographicType != null)
                {
                    return demographicType;
                }

            }
            return null;
        }


        [HttpPut]
        [Route("EditDemographicType")]
        public async Task<DemographicTypeTbl> EditDemographicType(CreateUpdateDemographicTypeDto input)
        {
            if (input == null)
            {
                return null;
            }
            var demographicType = await _demographicTypeRepository.EditDemographicTypeAsync(input);
            if (demographicType != null)
            {
                return demographicType;
            }
            return null;
        }
    }
}
