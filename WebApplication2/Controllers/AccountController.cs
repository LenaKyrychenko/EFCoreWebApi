using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ClassLibrary1.Entities;
using WebApplication2.ViewModels;
using ClassLibrary1.Interfaces.IServices;
using BLL.DTO;

namespace CustomIdentityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDTO userDTO = new UserDTO()
                {
                    Password = model.Password,
                    Email = model.Email,
                    Name = model.Email
                };
               var result = await _userService.CreateAsync(userDTO);
                if (result.Success)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return NotFound(result.Message);
                }
            }
            return View(model);
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
                UserDTO userDTO = new UserDTO()
                {
                    Email = model.Email,
                    Password = model.Password
                };
                var result = await _userService.SignInAsync(userDTO);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            _userService.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}
