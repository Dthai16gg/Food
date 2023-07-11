using System.ComponentModel.DataAnnotations;

namespace Common.Common.Entity.Entity.Product;

public class PriceMapping : IEntity.IEntity
{
    [Required(ErrorMessage = "Price is required")]
    [Range(0, 10000000, ErrorMessage = "Price must be between 0 and 10000000")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "PizzaSizeId is required")]
    public Guid PizzaSizeId { get; set; }

    [Required(ErrorMessage = "PizzaPanId is required")]
    public Guid PizzaPanId { get; set; }

    [Required(ErrorMessage = "ProductId is required")]
    public Guid ProductId { get; set; }

    public virtual PizzaSize? PizzaSize { get; set; }
    public virtual PizzaPan? PizzaPan { get; set; }
    public virtual PizzaProduct? Product { get; set; }

    [Required(ErrorMessage = "Id is required")]
    public Guid Id { get; set; }
}