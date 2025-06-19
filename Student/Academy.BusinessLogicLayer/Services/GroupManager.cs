using Academy.BusinessLogicLayer.Dtos;
using Academy.BusinessLogicLayer.Services.Contracts;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using AutoMapper;

namespace Academy.BusinessLogicLayer.Services
{
    public class GroupManager : CrudManager<GroupDto, GroupCreateDto, GroupUpdateDto, Group>, IGroupService
    {
        public GroupManager(IRepositoryAsync<Group> repository , IMapper mapper) : base(repository , mapper)
        {
        }
    }

}
