using Microsoft.AspNetCore.Mvc;
using ClientManagementBackend.DTOs;
using ClientManagementBackend.Services;

namespace ClientManagementBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService) => _authService = authService;

        [HttpPost("register")]
        public IActionResult Register(UserRegisterDto dto) => Ok(_authService.Register(dto));

        [HttpPost("login")]
        public IActionResult Login(UserLoginDto dto) => Ok(_authService.Login(dto));
    }
}
