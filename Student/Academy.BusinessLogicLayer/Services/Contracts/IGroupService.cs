using Academy.BusinessLogicLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Services.Contracts
{
    public interface IGroupService :ICrudService<GroupDto ,GroupCreateDto , GroupUpdateDto ,Group>
    {

    }
}
