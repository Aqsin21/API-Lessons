using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;


namespace Academy.DataAccessLayer.Repositories
{
    public class TeacherRepository :EfCoreRepository<Teacher> ,ITeacherRepository
    {
        public TeacherRepository (AppDbContext dbContext) : base(dbContext) { }

    }
}
