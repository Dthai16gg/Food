using System.ComponentModel.DataAnnotations;

namespace Common.Common.Entity.Entity.Product;

public class PizzaPan : IEntity.IEntity
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(20, ErrorMessage = "Max Length is 20 letter")]
    [MinLength(3, ErrorMessage = "Min Length is 3 letter")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Id is required")]
    public Guid Id { get; set; }
}