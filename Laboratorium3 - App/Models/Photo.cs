using System.ComponentModel.DataAnnotations;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium3___App.Models;

public class Photo
{
    [HiddenInput]
    public int Id { get; set; }
    
    [HiddenInput]
    public DateTime Created { set; get; }
    
    [Display(Name = "Data i godzina")]
    public DateTime Date { get; set; }
    
    [Display(Name = "Opis")]
    public string Description { get; set; }
    [Display(Name = "Aparat")]
    public int CameraId { get; set; }
    [Display(Name = "Aparat")]
    public string? CameraName { get; set;}
    [Display(Name = "Aparat")]
    [ValidateNever]
    public List<SelectListItem> Cameras { get; set; }
    [Display(Name = "Autor")]
    public int AuthorId { get; set; }
    [Display(Name = "Autor")]
    [ValidateNever]
    public List<SelectListItem> Authors { get; set; }
    [Display(Name = "Autor")]
    public string? AuthorPseudonym { get; set; }
    
    [Display(Name = "Rozdzielczość")]
    public string Resolution { get; set; }
    
    [Display(Name = "Proporcje")]
    public string AspectRatio { get; set; }
    
    [Display(Name = "Priorytet")]
    public int Priority { get; set; }
}