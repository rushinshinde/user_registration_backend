using ClientManagementBackend.DTOs;
using ClientManagementBackend.Models;
using ClientManagementBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClientManagementBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ClientsController : ControllerBase
    {
        private readonly ClientService _clientService;

        public ClientsController(ClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            return Ok(_clientService.GetClients());
        }

        [HttpPost]
        public IActionResult AddClient(ClientDto dto)
        {
            var client = _clientService.AddClient(dto);
            return Ok(client);
        }
    }
}
