using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Models;

public class Contact
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz podać imię!")]
    [StringLength(maximumLength: 50, ErrorMessage = "Za długie imię, wpisz max 50 znaków!")]
    public string Name { get; set; }
    
    [EmailAddress(ErrorMessage = "Podaj poprawny adres email!")]
    [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
    public string Email { get; set; }
    
    [Phone]
    public string Phone { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime? Birth { get; set; }
    
    
}