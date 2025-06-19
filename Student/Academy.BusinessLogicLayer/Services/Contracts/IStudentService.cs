using Academy.BusinessLogicLayer.Dtos;
using Academy.DataAccessLayer.DataContext.Entities;


namespace Academy.BusinessLogicLayer.Services.Contracts
{
    public interface IStudentService :ICrudService<StudentDto ,StudentCreateDto ,StudentUpdateDto ,Student>
    {
       
    }
}
