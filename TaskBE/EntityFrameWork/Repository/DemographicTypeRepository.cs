using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TaskBE.Dtos;
using TaskBE.Entities;
using TaskBE.EntityFrameWork.IRepository;

namespace TaskBE.EntityFrameWork.Repository
{
    public class DemographicTypeRepository: IDemographicTypeRepository
    {
        private readonly TaskContext _db;


        public DemographicTypeRepository(TaskContext db)
        {
            _db = db;
        }

        public async Task<DemographicTypeTbl> AddDemographicTypeAsync(CreateUpdateDemographicTypeDto input)
        {
            if (input == null)
            {
                return null;
            }
            var demographicType = new DemographicTypeTbl
            {
                DemTypeId = input.DemTypeId,
                TypeDescAr=input.TypeDescAr,
                TypeDescEn=input.TypeDescEn

            };
            _db.DemographicTypeTbls.Add(demographicType);
            await _db.SaveChangesAsync();
            return demographicType;
        }

        public Task<CreateUpdateDto> AddUpdatelist(CreateUpdateDto createUpdateDto)
        {
            if (createUpdateDto.AddList.Count > 0)
            {
                _db.DemographicTypeTbls.AddRange(createUpdateDto.AddList);
                var status=_db.SaveChanges();
                if (status < 1) { throw new Exception("error is occured in create operation"); }
            }
            if (createUpdateDto.UpdateList.Count > 0)
            {
                _db.DemographicTypeTbls.UpdateRange(createUpdateDto.UpdateList);
                var status = _db.SaveChanges();
                if (status < 1) { throw new Exception("error is occured in update operation"); }

            }
            return Task.FromResult(createUpdateDto);
        }

        public async Task<DemographicTypeTbl> DeleteAsync(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var demographicType = await _db.DemographicTypeTbls.FirstOrDefaultAsync(x => x.DemTypeId == id);
            if (demographicType == null)
            {
                return null;
            }
            else
            {
                _db.DemographicTypeTbls.Remove(demographicType);
                _db.SaveChanges();
            }
            return demographicType;
        }

        public async Task<DemographicTypeTbl> EditDemographicTypeAsync(CreateUpdateDemographicTypeDto input)
        {
            if (input == null || input.DemTypeId < 1)
            {
                return null;
            }
            var demographicType = await _db.DemographicTypeTbls.FirstOrDefaultAsync(x => x.DemTypeId == input.DemTypeId);
            if (demographicType == null)
            {
                return null;
            }

            _db.DemographicTypeTbls.Attach(demographicType);
            demographicType.TypeDescAr = input.TypeDescAr;
            demographicType.TypeDescEn = input.TypeDescEn;


            _db.Entry(demographicType).Property(x => x.TypeDescAr).IsModified = true;
            _db.Entry(demographicType).Property(x => x.TypeDescEn).IsModified = true;


            await _db.SaveChangesAsync();
            return demographicType;
        }

        public async Task<IEnumerable<DemographicTypeTbl>> GetAllDemographicTypes()
        {
            return await _db.DemographicTypeTbls.Include(x=>x.demographicTypeDTLTbls).ToListAsync();
        }

        public async Task<DemographicTypeTbl> GetAsync(int id)
        {

            if (id == 0)
            {
                return null;
            }
            var demographicType = await _db.DemographicTypeTbls.Include(x=>x.demographicTypeDTLTbls).FirstOrDefaultAsync(x => x.DemTypeId == id);
            if (demographicType == null)
            {
                return null;
            }
            return demographicType;
        }
    }
}
