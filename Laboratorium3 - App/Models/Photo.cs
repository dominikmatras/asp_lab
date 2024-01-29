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
    [DataType(DataType.Date)]
    public DateTime Created { set; get; }
    
    [Required(ErrorMessage = "Musisz podać date oraz godzinę!")]
    [Display(Name = "Data i godzina")]
    public DateTime Date { get; set; }
    
    [Required(ErrorMessage = "Musisz podać opis zdjęcia!")]
    [StringLength(maximumLength: 50, ErrorMessage = "Za długi opis, wpisz maksymalnie 50 znaków!")]
    [Display(Name = "Opis")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "Musisz podać nazwę aparatu!")]
    [Display(Name = "Aparat")]
    public string Camera { get; set; }
    
    [Required(ErrorMessage = "Musisz podać autora zdjęcia!")]
    [Display(Name = "Autor")]
    public int AuthorId { get; set; }
    [Display(Name = "Autor")]
    [ValidateNever]
    public List<SelectListItem> Authors { get; set; }
    [Display(Name = "Autor")]
    public string? AuthorPseudonym { get; set; }
    
    [Required(ErrorMessage = "Musisz podać rozdzielczość zdjęcia!")]
    [Display(Name = "Rozdzielczość")]
    public string Resolution { get; set; }
    
    [Required(ErrorMessage = "Musisz podać proporcje zdjęcia!")]
    [Display(Name = "Proporcje")]
    public string AspectRatio { get; set; }
    
    [Required(ErrorMessage = "Musisz podać priorytet zdjęcia!")]
    [Display(Name = "Priorytet")]
    public int Priority { get; set; }
    
    [HiddenInput]
    public int OrganizationId { get; set; }
    
    [Display(Name = "Organizacja")]
    [ValidateNever]
    public List<SelectListItem> Organizations { get; set; }
    
    [Display(Name = "Organizacja")]
    public string? OrganizationName { get; set; }
}