using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiLeasing.Web.Helpers;
using MiLeasing.Web.Models;

namespace MiLeasing.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;

        public AccountController(IUserHelper userHelper)
        {
            _userHelper = userHelper;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(String.Empty,"User or Password Incorrect");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        { 

            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
