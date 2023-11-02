namespace Laboratorium3___App.Models;

public interface IPhotoService
{
    void Add(Photo photo);
    void Update(Photo photo);
    void DeleteById(int Id);
    Photo? FindById(int Id);
    List<Photo>? FindAll();
}