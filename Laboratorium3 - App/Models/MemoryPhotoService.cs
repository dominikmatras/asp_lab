namespace Laboratorium3___App.Models;

public class MemoryPhotoService : IPhotoService
{
    private readonly Dictionary<int, Photo> _photos = new Dictionary<int, Photo>();
    
    private readonly IDateTimeProvider _timeProvider;
    
    public MemoryPhotoService(IDateTimeProvider timeProvider)
    {
        _timeProvider = timeProvider;
    }
    
    private int _id = 3;
    
    public int Add(Photo photo)
    {
        photo.Created = _timeProvider.CurrentDataTimeProvider();
        photo.Id = _id++;
        _photos[photo.Id] = photo;
        return 0;
    }
    
    public void Update(Photo photo)
    {
        _photos[photo.Id] = photo;
    }

    public void DeleteById(int Id)
    {
        _photos.Remove(Id);
    }
    
    public Photo? FindById(int id)
    {
        return _photos[id];
    }
    
    public List<Photo>? FindAll()
    {
        return _photos.Values.ToList();
    }
}