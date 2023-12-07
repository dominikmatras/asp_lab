using Data;
using Data.Entities;
using Laboratorium3___App.Mappers;

namespace Laboratorium3___App.Models;

public class EFPhotoService : IPhotoService
{
  private AddDbContext _context;
  
  public EFPhotoService(AddDbContext context)
  {
    _context = context;
  }
  
  public int Add(Photo contact)
  {
    var e= _context.Photos.Add(PhotoMapper.ToEntity(contact));
    _context.SaveChanges();
    return e.Entity.Id;
  }

  public void Update(Photo photo)
  {
    _context.Photos.Update(PhotoMapper.ToEntity(photo));
  }

  public void DeleteById(int Id)
  {
    PhotoEntity? find = _context.Photos.Find(Id);
    if ( find != null)
    {
      _context.Photos.Remove(find);
    }
  }

  public Photo? FindById(int Id)
  {
    return PhotoMapper.FromEntity(_context.Photos.Find(Id));
  }

  public List<Photo>? FindAll()
  {
    return _context.Photos.Select(e => PhotoMapper.FromEntity(e)).ToList(); ;
  }
}