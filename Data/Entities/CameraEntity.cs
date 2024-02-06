using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("Camera")]
public class CameraEntity
{
  public int Id { get; set; }
  public string? Model { get; set; }
  public string? Producer { get; set; }
  public string? SerialNumber { get; set; }
  public ISet<PhotoEntity> Photos { get; set;}
}