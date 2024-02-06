using Data;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Controllers;

[Route("api/photos")]
[ApiController]
public class PhotoApiController : ControllerBase
{
  private readonly AppDbContext _context;
  
  public PhotoApiController(AppDbContext context)
  {
    _context = context;
  }
  
  [HttpGet]
  public IActionResult GetAllAuthors()
  {
    
    var photos = _context.Photos
      .Select(a => new
      {
        a.Id,
        a.Date,
        a.Description,
        a.Camera,
        a.AuthorId,
        a.Resolution,
        a.AspectRatio,
        a.Priority
      })
      .ToList();

    return Ok(photos);
  }
}