using Laboratorium3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Controllers;

public class ContactController : Controller
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }
    public IActionResult Index()
    {
        return View(_contactService.FindAll());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Contact model)
    {
        if (ModelState.IsValid)
        {
            _contactService.Add(model);
            return RedirectToAction("index");
        }

        return View();
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        return View(_contactService.FindById(id));
    }

    [HttpPost]
    public IActionResult Update(Contact model)
    {
        if (ModelState.IsValid)
        {
            _contactService.Update(model);
            return RedirectToAction("Index");
        }

        return View();
    }
    public IActionResult Details()
    {
        throw new NotImplementedException();
    }

    public IActionResult Delete()
    {
        throw new NotImplementedException();
    }
}