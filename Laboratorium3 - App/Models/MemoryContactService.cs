namespace Laboratorium3___App.Models;

public class MemoryContactService : IContactService
{
    private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
    {
        { 1, new Contact() { Id = 1, Name = "Adam", Email = "adamjestem@onet.pl", Phone = "666555444" } },
        { 2, new Contact() { Id = 2, Name = "Aneta", Email = "aneta@wp.pl", Phone = "123456789" } }
    };

    private int _id = 3;
    
    public void Add(Contact contact)
    {
        contact.Id = _id++;
        _contacts[contact.Id] = contact;
    }

    public void Update(Contact contact)
    {
        _contacts[contact.Id] = contact;
    }

    public void DeleteById(int Id)
    {
        _contacts.Remove(Id);
    }

    public Contact? FindById(int id)
    {
        return _contacts[id];
    }

    public List<Contact>? FindAll()
    {
        return _contacts.Values.ToList();
    }
}