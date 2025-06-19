using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;





namespace Academy.DataAccessLayer.Repositories
{
    public class GroupRepository :EfCoreRepository<Group> , IGroupRepository
    {
        public GroupRepository(AppDbContext dbContext) : base(dbContext) { }

    }
}
