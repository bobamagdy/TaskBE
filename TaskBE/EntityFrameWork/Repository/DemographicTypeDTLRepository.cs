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
    public class DemographicTypeDTLRepository: IDemographicTypeDTLRepository
    {
        private readonly TaskContext _db;


        public DemographicTypeDTLRepository(TaskContext db)
        {
            _db = db;
        }

        public async Task<DemographicTypeDTLTbl> AddDemographicTypeDTLAsync(createUpdateDemographicTypeDTLDto input)
        {
            var demographicTypeDTL = new DemographicTypeDTLTbl
            {
                DemTypeDTL_ID = input.DemTypeDTL_ID,
                ChoicesAr = input.ChoicesAr,
                ChoicesEn = input.ChoicesEn,
                DemTypeID=input.DemTypeID,
                WeightValue=input.WeightValue,
            };
            _db.DemographicTypeDTLTbls.Add(demographicTypeDTL);
            await _db.SaveChangesAsync();
            return demographicTypeDTL;
        }

        public async Task<DemographicTypeDTLTbl> DeleteAsync(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var demographicTypeDTL = await _db.DemographicTypeDTLTbls.FirstOrDefaultAsync(x => x.DemTypeDTL_ID == id);
            if (demographicTypeDTL == null)
            {
                return null;
            }
            else
            {
                _db.DemographicTypeDTLTbls.Remove(demographicTypeDTL);
                _db.SaveChanges();
            }
            return demographicTypeDTL;
        }

        public async Task<DemographicTypeDTLTbl> EditDemographicTypeDTLAsync(createUpdateDemographicTypeDTLDto input)
        {
            if (input == null || input.DemTypeDTL_ID < 1)
            {
                return null;
            }
            var demographicTypeDTL = await _db.DemographicTypeDTLTbls.Include(x => x.DemographicTypeTbl).FirstOrDefaultAsync(x => x.DemTypeDTL_ID == input.DemTypeDTL_ID);
            if (demographicTypeDTL == null)
            {
                return null;
            }

            _db.DemographicTypeDTLTbls.Attach(demographicTypeDTL);
            demographicTypeDTL.DemTypeDTL_ID = input.DemTypeDTL_ID;
            demographicTypeDTL.ChoicesAr = input.ChoicesAr;
            demographicTypeDTL.ChoicesEn = input.ChoicesEn;
            demographicTypeDTL.DemTypeID = input.DemTypeID;
            demographicTypeDTL.WeightValue = input.WeightValue;


            _db.Entry(demographicTypeDTL).Property(x => x.DemTypeID).IsModified = true;
            _db.Entry(demographicTypeDTL).Property(x => x.ChoicesEn).IsModified = true;
            _db.Entry(demographicTypeDTL).Property(x => x.ChoicesAr).IsModified = true;
            _db.Entry(demographicTypeDTL).Property(x => x.WeightValue).IsModified = true;


            await _db.SaveChangesAsync();
            return demographicTypeDTL;
        }

        public async Task<IEnumerable<DemographicTypeDTLTbl>> GetAllDemographicTypeDTLs()
        {
            return await _db.DemographicTypeDTLTbls.Include(x => x.DemographicTypeTbl).ToListAsync();

        }

        public async Task<DemographicTypeDTLTbl> GetAsync(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var demographicTypeDTL = await _db.DemographicTypeDTLTbls.Include(x => x.DemographicTypeTbl).FirstOrDefaultAsync(x => x.DemTypeDTL_ID == id);
            if (demographicTypeDTL == null)
            {
                return null;
            }
            return demographicTypeDTL;
        }
    }
}
