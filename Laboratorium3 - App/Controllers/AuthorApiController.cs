using Data;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Controllers;

[Route("api/authors")]
[ApiController]
public class AuthorApiController : ControllerBase
{
  private readonly AppDbContext _context;
  
  public AuthorApiController(AppDbContext context)
  {
    _context = context;
  }
  
  [HttpGet]
  public IActionResult GetAllAuthors()
  {
    return Ok(_context.Authors.ToList());
  }
  
  [HttpGet("filter")] 
  public IActionResult GetFiltered(string filter)
  {
    return Ok(_context.Authors
      .Where(a => a.FirstName.StartsWith(filter))
      .Select(a => new {a.Id, a.FirstName, a.LastName, a.Pseudonym})
      .ToList());
  }
}