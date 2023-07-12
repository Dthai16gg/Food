using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Common.Common.Entity.Entity.Combo;
using Common.Common.Entity.Entity.Oder;

namespace Common.Common.Entity.Entity.Product
{
  public class Drink : IEntity.IEntity
  {
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(30, ErrorMessage = "Max Length is 30 letters")]
    public string? Name { get; set; }
    [MaxLength(200, ErrorMessage = "Max Length is 200 letters")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }
    public Guid TitleId { get; set; }
    public virtual Title? Title { get; set; }
    public List<ComboMapping>? ComboMappings { get; set; }
    public List<OderDetails>? OderDetails { get; set; }
  }
}
