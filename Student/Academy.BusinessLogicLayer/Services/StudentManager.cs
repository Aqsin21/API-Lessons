using Academy.BusinessLogicLayer.Dtos;
using Academy.BusinessLogicLayer.Services.Contracts;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using AutoMapper;

namespace Academy.BusinessLogicLayer.Services
{
    public class StudentManager : CrudManager<StudentDto, StudentCreateDto, StudentUpdateDto, Student>, IStudentService
    {
        public StudentManager(IRepositoryAsync<Student> repository , IMapper mapper) : base(repository , mapper)
        {
        }
    }

}
