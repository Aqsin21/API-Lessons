using Academy.BusinessLogicLayer.Dtos;
using Academy.BusinessLogicLayer.Services.Contracts;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Services
{
    public class TeacherGroupManager : CrudManager<TeacherGroupDto, TeacherGroupCreateDto, TeacherGroupUpdateDto, TeacherGroup>, ITeacherGroupService
    {
        public TeacherGroupManager(IRepositoryAsync<TeacherGroup> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
