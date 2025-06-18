using Academy.DataAccessLayer.DataContext.Entities;
using Academy.DataAccessLayer.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupRepository _repository;

        public GroupsController(IGroupRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var groups = await _repository.GetAllAsync();
            return Ok(groups);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var group = await _repository.GetByIdAsync(id);
            if (group == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(group);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Group group)
        {
            if (group == null)
            {
                return BadRequest("Group data is null");
            }
            await _repository.AddAsync(group);

            return CreatedAtAction(nameof(GetAll), new { id = group.Id }, group);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _repository.DeleteAsync(id);

            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Group group)
        {

            if (id != group.Id)
            {
                return BadRequest("Not Found");
            }
            await _repository.UpdateAsync(group);

            return NoContent();

        }
    }
}
