using System.ComponentModel.DataAnnotations;

namespace Common.Common.Entity.Entity.Product;

public abstract class PizzaProduct : IEntity.IEntity
{
    [Required]
    [MaxLength(30, ErrorMessage = "Max length is 30 cha")]
    [MinLength(3)]
    public string? Name { get; set; }

    [Required] public Guid Id { get; set; }
}