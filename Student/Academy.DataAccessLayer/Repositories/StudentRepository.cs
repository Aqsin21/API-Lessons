using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;


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
