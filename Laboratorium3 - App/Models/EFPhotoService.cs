using Data;
using Data.Entities;
using Laboratorium3___App.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Laboratorium3___App.Models;

public class EfPhotoService : IPhotoService
{
  private AppDbContext _context;
  
  public EfPhotoService(AppDbContext context)
  {
    _context = context;
  }
  
  public int Add(Photo photo)
  {
    var e= _context.Photos.Add(PhotoMapper.ToEntity(photo));
    _context.SaveChanges();
    return e.Entity.Id;
  }

  public void Update(Photo photo)
  {
    var entity = PhotoMapper.ToEntity(photo);
    _context.Photos.Update(entity);
    _context.SaveChanges();
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
    var photoEntity = _context.Photos
      .Include(p => p.Organization)
      .Include(p => p.Author)
      .FirstOrDefault(p => p.Id == Id);

    if (photoEntity == null) return null;
    
    return PhotoMapper.FromEntity(photoEntity);
  }

  public List<Photo>? FindAll()
  {
    return _context.Photos
      .Include(p => p.Author) 
      .Select(p => PhotoMapper.FromEntity(p))
      .ToList();
    
    //return _context.Photos.Select(e => PhotoMapper.FromEntity(e)).ToList(); ;
  }

  public List<OrganizationEntity> FindAllOrganizationsForVieModel()
  {
    return _context.Organizations.ToList();
  }

  public List<AuthorEntity> FindAllAuthorsForVieModel()
  {
    return _context.Authors.ToList();
  }
}