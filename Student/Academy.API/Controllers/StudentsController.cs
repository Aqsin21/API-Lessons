using Academy.BusinessLogicLayer.Dtos;
using Academy.BusinessLogicLayer.Services.Contracts;
using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var studentsDto = await _studentService.GetAllAsync();
            return Ok(studentsDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var studentDto = await _studentService.GetByIdAsync(id);
            if (studentDto == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(studentDto);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StudentCreateDto studentCreateDto)
        {
            if (studentCreateDto == null)
            {
                return BadRequest("Student data is null");
            }
            var result =  await _studentService.AddAsync(studentCreateDto);

            return CreatedAtAction(nameof(GetAll), new { id = result.Id }, studentCreateDto);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _studentService.DeleteAsync(id);
           
            return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id , [FromBody] StudentUpdateDto studentUpdateDto)
        {
          
            if (id !=studentUpdateDto.Id)
            {
                return BadRequest("Not Found");
            }
            var result= await _studentService.UpdateAsync(studentUpdateDto);
    
            return Ok(result);
              
        }


       



    }
}

