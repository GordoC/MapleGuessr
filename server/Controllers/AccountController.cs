using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using server.Dtos;
using server.Interfaces;
using server.Models;

namespace server.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        public AccountController(UserManager<User> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try 
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var user = new User
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email
                };
                
                var createUser = await _userManager.CreateAsync(user, registerDto.Password);

                if (createUser.Succeeded) 
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, "User");
                    if (roleResult.Succeeded) 
                    {
                        return Ok(
                            new NewUser 
                            {
                                UserName = user.UserName,
                                Email = user.Email,
                                Token = _tokenService.CreateToken(user)
                            }
                        );
                    } 
                    else 
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                } 
                else 
                {
                    return StatusCode(500, createUser.Errors);
                }
            } 
            catch (Exception e) 
            {
                return StatusCode(500, e);
            }
        }
    }
}