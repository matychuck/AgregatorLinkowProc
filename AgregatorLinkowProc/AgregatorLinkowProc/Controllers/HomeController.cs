using AgregatorLinkowProc.DAL.Interfaces;
using AgregatorLinkowProc.Models;
using AgregatorLinkowProc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserService _userService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, UserService userService)
        {
            _logger = logger;
            this._userService = userService;
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
