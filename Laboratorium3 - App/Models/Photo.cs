using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Models;

public class Photo
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz podać date oraz godzinę!")]
    public DateTime Date { get; set; }
    
    [Required(ErrorMessage = "Musisz podać opis zdjęcia!")]
    [StringLength(maximumLength: 50, ErrorMessage = "Za długi opis, wpisz maksymalnie 50 znaków!")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "Musisz podać nazwę aparatu!")]
    public string Camera { get; set; }
    
    [Required(ErrorMessage = "Musisz podać autora zdjęcia!")]
    public string Author { get; set; }
    
    [Required(ErrorMessage = "Musisz podać rozdzielczość zdjęcia!")]
    public string Resolution { get; set; }
    
    [Required(ErrorMessage = "Musisz podać proporcje zdjęcia!")]
    public string AspectRatio { get; set; }
}