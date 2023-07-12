using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Common.Common.Entity.Entity.Product;
using Common.Common.Entity.Entity.Oder;

namespace Common.Common.Entity.Entity.Combo;

public class Combos : IEntity.IEntity
{
  public Guid Id { get; set; }
  [Required(ErrorMessage = "Name is required")]
  [MaxLength(30, ErrorMessage = "Max Length is 30 letter")]
  public string? Name { get; set; }
  [MaxLength(200, ErrorMessage = "Max Length is 200 letter")]
  public string? Description { get; set; }
  [Required(ErrorMessage = "Price is required")]
  public decimal TotalPrice { get; set; }
  [Required(ErrorMessage = "Status is required")]
  public bool Status { get; set; }
  [AllowNull]
  [DataType(DataType.Date)]
  public DateTime TimeStart { get; set; }
  [AllowNull]
  [DataType(DataType.Date)]
  public DateTime TimeEnd { get; set; }
  [AllowNull]
  public Guid? TitleId { get; set; }
  public virtual Title? Title { get; set; }
  public List<ComboMapping>? ComboMappings { get; set; }
  public List<OderDetails>? OrderDetails { get; set; }
}
