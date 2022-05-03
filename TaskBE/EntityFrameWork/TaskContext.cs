

using Microsoft.EntityFrameworkCore;
using TaskBE.Entities;

namespace TaskBE.EntityFrameWork
{
    public class TaskContext: DbContext
    {
        public TaskContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<DemographicTypeTbl> DemographicTypeTbls { get; set; }
        public DbSet<DemographicTypeDTLTbl> DemographicTypeDTLTbls { get; set; }
    }
}
