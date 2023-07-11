using System.ComponentModel.DataAnnotations;

namespace Common.Common.Entity.Entity.Product;

public class Title : IEntity.IEntity
{
    [Required(ErrorMessage = "Id is required")]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }
}