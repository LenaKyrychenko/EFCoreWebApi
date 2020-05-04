using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ClassLibrary1.Entities;
using WebApplication2.ViewModels;
using ClassLibrary1.Interfaces.IServices;
using BLL.DTO;

namespace CustomIdentityApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
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

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDTO userDTO = new UserDTO()
                {
                    Email = model.Email,
                    Password = model.Password
                };
                var result = _userService.SignInAsync(userDTO);
                if (result.Result.Success)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return NotFound(result.Result.Message);
                }
            }
            return View(model);
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
