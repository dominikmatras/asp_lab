namespace Laboratorium3___App.Models;

public class MemoryPhotoService : IPhotoService
{
    private readonly Dictionary<int, Photo> _photos = new Dictionary<int, Photo>()
    {
        { 1, new Photo() {Id = 1, Author = "Jan Kowalski", Camera = "Sony A6300", Resolution = "1920x1080", AspectRatio = "16:9", Priority = (Priority)1} },
        { 2, new Photo() {Id = 2, Author = "Michał Nowak", Camera = "Canon R1", Resolution = "1280x960", AspectRatio = "16:9", Priority = (Priority)3} }
    };
    
    private readonly IDateTimeProvider _timeProvider;
    
    public MemoryPhotoService(IDateTimeProvider timeProvider)
    {
        _timeProvider = timeProvider;
    }
    
    private int _id = 3;
    
    public void Add(Photo photo)
    {
        photo.Created = _timeProvider.CurrentDataTimeProvider();
        photo.Id = _id++;
        _photos[photo.Id] = photo;
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