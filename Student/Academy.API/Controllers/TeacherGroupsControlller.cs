using Academy.DataAccessLayer.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherGroupsControlller : ControllerBase
    {
        private readonly ITeacherGroupRepository _repository;

        public TeacherGroupsControlller(ITeacherGroupRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var teachergroups = await _repository.GetAllAsync();
            return Ok(teachergroups);
        }
        
    }
}
