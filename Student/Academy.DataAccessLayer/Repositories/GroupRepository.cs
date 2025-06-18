using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using System.Text.RegularExpressions;
using Group = Academy.DataAccessLayer.DataContext.Entities.Group;



namespace Academy.DataAccessLayer.Repositories
{
    public class GroupRepository :EfCoreRepository<Group> , IGroupRepository
    {
        public GroupRepository(AppDbContext dbContext) : base(dbContext) { }

    }
}
