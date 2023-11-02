using Laboratorium3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Controllers;

public class PhotoController : Controller
{
    private readonly IPhotoService _photoService;
    private readonly IDateTimeProvider _timeProvider;
    
    public PhotoController(IPhotoService photoService, IDateTimeProvider timeProvider)
    {
        _photoService = photoService;
        _timeProvider = timeProvider;
    }
    public IActionResult Index()
    {
        return View(_photoService.FindAll());
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Photo model)
    {
        if (ModelState.IsValid)
        {
            _photoService.Add(model);
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Edit(int Id)
    {
        return View(_photoService.FindById(Id));
        
    }
    
    [HttpPost]
    public IActionResult Edit(Photo model)
    {
        if (ModelState.IsValid)
        {
            _photoService.Update(model);
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Details(int Id)
    {
        return View(_photoService.FindById(Id));
    }
    [HttpGet]
    public IActionResult Delete(Photo model)
    {
        return View(_photoService.FindById(model.Id));
    }
    
    [HttpPost]
    public IActionResult Delete(int Id)
    {
        _photoService.DeleteById(Id);
        return RedirectToAction("Index");
    }
}