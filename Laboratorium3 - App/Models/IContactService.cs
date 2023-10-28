namespace Laboratorium3___App.Models;

public interface IContactService
{
    void Add(Contact contact);
    void Update(Contact contact);
    void DeleteById(int Id);
    Contact? FindById(int Id);
    List<Contact>? FindAll();
}