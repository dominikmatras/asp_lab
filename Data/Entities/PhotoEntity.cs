using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;
[Table("Photos")]
public class PhotoEntity
{
  public int Id { get; set; }
  
  public DateTime Created { set; get; }
  [Required]
  public DateTime Date { get; set; }
  [MaxLength(50)]
  public string Description { get; set; }
  public int CameraId { get; set; }
  public CameraEntity Camera { get; set; }
  public int AuthorId { get; set; }
  public AuthorEntity Author { get; set; }
  
  [Required]
  [MaxLength(15)]
  public string Resolution { get; set; }
  [MaxLength(15)]
  public string AspectRatio { get; set; }
  [Required]
  [Range(1, 4)]
  public int Priority { get; set; }
}