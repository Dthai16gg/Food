using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Common.Common.Entity.Entity.Product;

public class NormalFood : IEntity.IEntity
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(30, ErrorMessage = "Max Length is 30 letter")]
    public string? Name { get; set; }
    [MaxLength(200, ErrorMessage = "Max Length is 200 letter")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }
    public Guid TitleId { get; set; }
    [AllowNull]
    public virtual Title? Title { get; set; }
}