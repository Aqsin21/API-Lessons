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
    public class TeacherManager : CrudManager<TeacherDto, TeacherCreateDto, TeacherUpdateDto, Teacher>, ITeacherService
    {
        public TeacherManager(IRepositoryAsync<Teacher> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
