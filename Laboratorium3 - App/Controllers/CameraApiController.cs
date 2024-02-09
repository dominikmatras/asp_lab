using Data;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3___App.Controllers;

[Route("api/cameras")]
[ApiController]
public class CameraApiController : ControllerBase
{
  private readonly AppDbContext _context;
  
  public CameraApiController(AppDbContext context)
  {
    _context = context;
  }
  
  [HttpGet]
  public IActionResult GetAllCameras()
  {
    return Ok(_context.Cameras.ToList());
  }
  
  [HttpGet("filter")] 
  public IActionResult GetFiltered(string filter)
  {
    return Ok(_context.Cameras
      .Where(a => a.Model.StartsWith(filter))
      .Select(a => new {a.Id, a.Model})
      .ToList());
  }
}