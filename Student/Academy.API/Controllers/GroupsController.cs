using Academy.BusinessLogicLayer.Dtos;
using Academy.BusinessLogicLayer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupService _groupService;

        public GroupsController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var groupDtos = await _groupService.GetAllAsync();
            return Ok(groupDtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var groupDto = await _groupService.GetByIdAsync(id);
            if (groupDto == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(groupDto);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GroupCreateDto groupCreateDto)
        {
            if (groupCreateDto == null)
            {
                return BadRequest("Group data is null");
            }
            var created=  await _groupService.AddAsync(groupCreateDto);

            return CreatedAtAction(nameof(GetAll), new { id = created.Id }, created);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _groupService.DeleteAsync(id);

            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] GroupUpdateDto groupUpdateDto)
        {

            if (id != groupUpdateDto.Id)
            {
                return BadRequest("Not Found");
            }
           var result=  await _groupService.UpdateAsync(groupUpdateDto);

            return Ok(result);

        }
    }
}
