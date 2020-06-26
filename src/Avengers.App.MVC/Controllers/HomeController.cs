using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Avangers.App.MVC.Models;

namespace Avangers.App.MVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPersonRepository _repo;

        public HomeController(IPersonRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
    }
}