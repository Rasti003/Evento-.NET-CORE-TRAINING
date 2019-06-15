using System;
using System.Threading.Tasks;
using Evento.Core.Repositories;
using Evento.Infrastructure.Commands.Users;
using Evento.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Evento.Api.Controllers
{
    public class AccountController : Controller
    {
        private IUserService  _userServices;
        public AccountController(IUserService userService)
        {
            _userServices = userService;
        }
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            throw  new NotImplementedException();
        }
        [HttpGet("tickets")]
        public async Task <IActionResult> GetTickets()
        {
            throw  new NotImplementedException();
        }

        [HttpGet("register")]
        public async Task<IActionResult> Post(Register command)
        {
          await _userServices.RegisterAsync(Guid.NewGuid(), command.Email, command.Name, command.Password,
                command.Role);
          return Created("/account", null);
        }

        [HttpGet("login")]
        public async Task <IActionResult> Post()
        {
            throw  new NotImplementedException();
        }
    }
}