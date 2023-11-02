using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Models;

public class Photo
{
    [HiddenInput]
    public int Id { get; set; }
    
    [HiddenInput]
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
    public string Author { get; set; }
    
    [Required(ErrorMessage = "Musisz podać rozdzielczość zdjęcia!")]
    [Display(Name = "Rozdzielczość")]
    public string Resolution { get; set; }
    
    [Required(ErrorMessage = "Musisz podać proporcje zdjęcia!")]
    [Display(Name = "Proporcje")]
    public string AspectRatio { get; set; }
    
    [Required(ErrorMessage = "Musisz podać priorytet zdjęcia!")]
    [Display(Name = "Priorytet")]
    public Priority Priority { get; set; }
}