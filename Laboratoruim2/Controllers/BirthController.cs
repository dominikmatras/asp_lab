using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratoruim2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoruim2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Birth model)
        { 
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}