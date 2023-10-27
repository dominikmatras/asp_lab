using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratoruim2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoruim2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public enum Operators
        {
            Unknown, Add, Mul, Sub, Div
        }

        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }

    }
}