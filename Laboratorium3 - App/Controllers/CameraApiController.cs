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
  public IActionResult GetCameras()
  {
    return Ok(_context.Cameras.ToList());
  }
}