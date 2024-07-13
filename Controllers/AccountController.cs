using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PaluwaganAPI.ViewModels;

namespace PaluwaganAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegistrationDto model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                CustomerAddress = model.CustomerAddress,
                CustomerPhone = model.CustomerPhone,
                CustomerEmail = model.CustomerEmail,

            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // Handle successful registration
                return Ok(new { message = "User registered successfully" });
            }

            // Handle registration failure
            return BadRequest(result.Errors);
        }
    }
}
