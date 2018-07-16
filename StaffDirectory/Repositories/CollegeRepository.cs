using StaffDirectory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Repositories
{
    public class CollegeRepository: GenericRepository<College>, ICollegeRepository
    {
        public CollegeRepository(StaffDirectoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
