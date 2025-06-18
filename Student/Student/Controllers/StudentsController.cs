using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCrud.DataContext;
using StudentCrud.DataContext.Entities;

namespace StudentCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public StudentsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
       public async Task<IActionResult> GetAll()
        {
            var students = await _dbContext.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var student =await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> Create([FromRoute] Student student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete ("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            var student = await _dbContext.Students.FirstOrDefaultAsync(x=>x.Id == id);
            if(student == null)
              return NotFound();
            _dbContext.Students.Remove(student);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update ([FromRoute] int id, Student updatedstudent)
        {
            if (id != updatedstudent.Id)
                return BadRequest("Id is not correct");
            var existingStudent = await _dbContext.Students.FirstOrDefaultAsync(x=>x.Id==id);
            if (existingStudent == null)
                return NotFound();
            existingStudent.Name = updatedstudent.Name;
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
