using API.JwtToken.Dtos;
using API.JwtToken.Entities;
using API.JwtToken.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.JwtToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
       

        public AuthController(AuthService authService)
        {
            _authService = authService;
           
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if (loginDto.UserName != "admin" || loginDto.Password != "1234")
            {
                return Unauthorized("Invalid username or password.");
            }

            var jwtResponseModel = await _authService.CreateToken(new JwtRequestModel
            {
                Username = loginDto.UserName
            });

           

            return Ok(jwtResponseModel);
        }
    }
}
