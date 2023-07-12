using System.ComponentModel.DataAnnotations;
using Common.Common.Entity.Entity.Combo;

namespace Common.Common.Entity.Entity.Product;

public class Title : IEntity.IEntity
{
  [Required(ErrorMessage = "Id is required")]
  public Guid Id { get; set; }
  [Required(ErrorMessage = "Name is required")]
  public string? Name { get; set; }
  public List<PizzaProduct>? PizzaProducts { get; set; }
  public List<Drink>? Drinks { get; set; }
  public List<Combos>? Combos { get; set; }
  public List<NormalFood>? NormalFoods { get; set; }
}
