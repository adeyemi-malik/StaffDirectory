﻿using StaffDirectory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Repositories
{
    public class QualificationRepository: GenericRepository<Qualification>, IQualificationRepository
    {
        public QualificationRepository(StaffDirectoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
