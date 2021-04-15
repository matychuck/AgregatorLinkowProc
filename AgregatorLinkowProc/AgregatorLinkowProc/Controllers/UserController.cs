using AgregatorLinkowProc.Filters;
using AgregatorLinkowProc.Models;
using AgregatorLinkowProc.Services;
using AgregatorLinkowProc.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [SessionEnded]
        public IActionResult SignUp()
        {
            RegisterVM model = new RegisterVM();

            return View(model);
        }

        [SessionEnded]
        [HttpPost]
        public IActionResult SignUp(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                User user = new User(model);
                if (_userService.AddNewUser(user))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Email", "User with this email already exists!");
                    return View(model);
                }
            }
            return View(model);
        }

        [SessionEnded]
        public IActionResult SignIn()
        {
            LoginVM model = new LoginVM();
            return View(model);
        }

        [SessionEnded]
        [HttpPost]
        public IActionResult SignIn(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var obj = _userService.TryToSignIn(model);
                if (obj == null)
                {
                    ModelState.AddModelError(string.Empty, "Incorrect login or password");
                    return View(model);
                }
                else
                {
                    HttpContext.Session.SetString("UserId", obj.UserId.ToString());
                    HttpContext.Session.SetString("UserName", obj.Email.ToString());
                }
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [LoggedUser]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [LoggedUser]
        public IActionResult CreatePost()
        {
            return View();
        }
    }
}
