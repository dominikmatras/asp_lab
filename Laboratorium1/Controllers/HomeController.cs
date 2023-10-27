using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Laboratorium1.Models;

namespace Laboratorium1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    public IActionResult About()
    {
        return View();
    }

    public enum Operator
    {
        Unknown, Add, Mul, Sub, Div
    }

    public IActionResult Calculator(Operator op, double a, double b)
    {
        if (a == null || b == null || op == null)
        {
            return View("Error");
        }


        ViewBag.Op = op;
        ViewBag.a = a;
        ViewBag.b = b;
        double r = 0;

        switch (op)
        {
            case Operator.Add:
                r = a + b;
                break;

            case Operator.Sub:
                r = a - b;
                break;
    
            case Operator.Mul:
                r = a * b;
                break;

            case Operator.Div:
                if (b == 0)
                {
                    return View("Error");
                }
                r = a / b;
                break;

            case Operator.Unknown:
                r = -1;
                break;
        }

            ViewBag.Result = r;

            return View();
        
    }
}

