using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _repository.GetAllAsync();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _repository.GetByIdAsync(id);
            if (student == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(student);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student data is null");
            }
            await _repository.AddAsync(student);

            return CreatedAtAction(nameof(GetAll), new { id = student.Id }, student);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _repository.DeleteAsync(id);
           
            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id , [FromBody] Student student)
        {
          
            if (id !=student.Id)
            {
                return BadRequest("Not Found");
            }
            await _repository.UpdateAsync(student);
    
            return NoContent();
              
        }


        [HttpGet("ONLY-STUDENT")]
        public IActionResult OnlyStudent()
        {
            var result = _repository.OnlyStudent();
            return Ok(result);
        }



    }
}