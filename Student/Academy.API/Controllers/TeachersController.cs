using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherRepository _repository;

        public TeachersController(ITeacherRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var teachers = await _repository.GetAllAsync();
            return Ok(teachers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var teacher = await _repository.GetByIdAsync(id);
            if (teacher == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(teacher);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Teacher teacher)
        {
            if (teacher == null)
            {
                return BadRequest("Teacher data is null");
            }
            await _repository.AddAsync(teacher);

            return CreatedAtAction(nameof(GetAll), new { id = teacher.Id }, teacher);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _repository.DeleteAsync(id);

            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Teacher teacher)
        {

            if (id != teacher.Id)
            {
                return BadRequest("Not Found");
            }
            await _repository.UpdateAsync(teacher);

            return NoContent();

        }





    }
}
