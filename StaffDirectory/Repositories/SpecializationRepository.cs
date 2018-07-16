using StaffDirectory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Repositories
{
    public class SpecializationRepository: GenericRepository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(StaffDirectoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
