using Academy.BusinessLogicLayer.Dtos;
using Academy.BusinessLogicLayer.Services;
using Academy.DataAccessLayer.DataContext.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly UserManager<AppUser> _userManager;

        public AuthController(AuthService authService, UserManager<AppUser> userManager)
        {
            _authService = authService;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto )
        {
            var user = await _userManager.FindByNameAsync(loginDto.Username);
            if (user == null  || await _userManager.CheckPasswordAsync(user , loginDto.Password ))
                {
                return Unauthorized("Invalid username or password");
                }

            var jwtResponseModel = await _authService.CreateToken(new JwtRequestModel
            {
                Username = user.UserName,
                Email = user.Email,
               
            });
            return Ok(jwtResponseModel);
        }
    }
}
