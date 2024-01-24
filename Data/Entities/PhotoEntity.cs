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
  public int OrganizationId { get; set; }
  public OrganizationEntity? Organization { get; set; }
}