using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class PhotoEntity
{
  public int Id { get; set; }
  
  public DateTime Created { set; get; }
  [Required]
  public DateTime Date { get; set; }
  [MaxLength(150)]
  public string Description { get; set; }
  [Required]
  [MaxLength(40)]
  public string Camera { get; set; }
  [Required]
  [MaxLength(60)]
  public string Author { get; set; }
  [Required]
  [MaxLength(15)]
  public string Resolution { get; set; }
  [MaxLength(15)]
  public string AspectRatio { get; set; }
  [Required]
  [Range(1, 4)]
  public int Priority { get; set; }
}

