using Academy.BusinessLogicLayer.Dtos;
using System.Text.RegularExpressions;


namespace Academy.BusinessLogicLayer.Services.Contracts
{
    public interface IGroupService :ICrudService<GroupDto ,GroupCreateDto , GroupUpdateDto ,Group>
    {

    }
}
