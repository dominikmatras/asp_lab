using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;
[Table("Author")]
public class AuthorEntity
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Pseudonym { get; set; }
  public ISet<PhotoEntity> Photos { get; set;}
}