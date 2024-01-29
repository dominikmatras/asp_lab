using Laboratorium3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium3___App.Controllers;
[Authorize(Roles = "admin")]
public class PhotoController : Controller
{
    private readonly IPhotoService _photoService;
    private readonly IDateTimeProvider _timeProvider;
    
    public PhotoController(IPhotoService photoService, IDateTimeProvider timeProvider)
    {
        _photoService = photoService;
        _timeProvider = timeProvider;
    }
    [AllowAnonymous]
    public IActionResult Index()
    {
        return View(_photoService.FindAll());
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        Photo model = new Photo();
        model.Organizations =  _photoService
            .FindAllOrganizationsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
            .ToList();
        
        model.Authors = _photoService
            .FindAllAuthorsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Pseudonym })
            .ToList();
        return View(model);
    }
    
    [HttpPost]
    public IActionResult Create(Photo model)
    {
        
        model.Organizations =  _photoService
            .FindAllOrganizationsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
            .ToList();
        
        model.Authors = _photoService
            .FindAllAuthorsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Pseudonym })
            .ToList();
        
        if (ModelState.IsValid)
        {
            _photoService.Add(model);
            return RedirectToAction("Index");
        }
        return View(model);
    }
    [HttpGet]
    public ActionResult CreateApi()
    {
        Photo model = new Photo();
        model.Authors = _photoService
            .FindAllAuthorsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Pseudonym })
            .ToList();
            
        return View(model);
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult CreateApi(Photo p)
    {
        if (ModelState.IsValid)
        {
            _photoService.Add(p);
            return RedirectToAction(nameof(Index));
        }
        return View();
    }

    [HttpGet]
    public IActionResult Edit(int Id)
    {
        Photo model = _photoService.FindById(Id);
        model.Organizations = _photoService
            .FindAllOrganizationsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
            .ToList();

        model.Authors = _photoService
            .FindAllAuthorsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Pseudonym })
            .ToList();
        
        return View(model);
    }
    
    [HttpPost]
    public IActionResult Edit(Photo model)
    {
        if (ModelState.IsValid)
        {
            _photoService.Update(model);
            return RedirectToAction("Index");
        }
        
        model.Organizations = _photoService
            .FindAllOrganizationsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
            .ToList();
        
        model.Authors = _photoService
            .FindAllAuthorsForVieModel()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Pseudonym })
            .ToList();
        
        return View(model);
    }
    [AllowAnonymous]
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
    public IActionResult Delete(int id)
    {
        _photoService.DeleteById(id);
        return RedirectToAction("Index");
    }
}