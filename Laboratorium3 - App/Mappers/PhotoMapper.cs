using Data.Entities;
using Laboratorium3___App.Models;

namespace Laboratorium3___App.Mappers;

public class PhotoMapper
{
  public static Photo FromEntity(PhotoEntity entity)
  {
    return new Photo()
    {
      Id = entity.Id, 
      Date = entity.Date, 
      Description = entity.Description, 
      CameraId = entity.CameraId,
      CameraName = entity.Camera?.Model,
      AuthorId = entity.AuthorId, 
      AuthorPseudonym = entity.Author?.Pseudonym,
      Resolution = entity.Resolution, 
      AspectRatio = entity.AspectRatio,
      Priority = entity.Priority,
    };
  }

  public static PhotoEntity ToEntity(Photo model)
  {
    return new PhotoEntity()
    {
      Id = model.Id, 
      Date = model.Date, 
      Description = model.Description, 
      CameraId = model.CameraId, 
      AuthorId = model.AuthorId,
      Resolution = model.Resolution, 
      AspectRatio = model.AspectRatio, 
      Priority = model.Priority,
    };
  }
}