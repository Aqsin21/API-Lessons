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
    public  class StudentRepository :EfCoreRepository<Student> , IStudentRepository
    {
        public StudentRepository(AppDbContext dbContext) : base(dbContext) { }
        public string OnlyStudent()
        {
            return "Hello";
        }
    }
}
