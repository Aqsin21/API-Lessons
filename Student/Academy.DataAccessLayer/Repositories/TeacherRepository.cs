using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DataAccessLayer.Repositories
{
    public class TeacherRepository :EfCoreRepository<Teacher> ,ITeacherRepository
    {
        public TeacherRepository (AppDbContext dbContext) : base(dbContext) { }

    }
}
