using StaffDirectory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Repositories
{
    public class DepartmentRepository: GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(StaffDirectoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
