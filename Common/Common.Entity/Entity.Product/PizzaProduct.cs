using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Common.Common.Entity.Entity.Product;

public abstract class PizzaProduct : IEntity.IEntity
{
    [Required]
    [MaxLength(30, ErrorMessage = "Max length is 30 characters")]
    [MinLength(3)]
    public string? Name { get; set; }

    [Required] public Guid Id { get; set; }
    //Description
    [Required]
    [MaxLength(1000, ErrorMessage = "Max length is 1000 characters")]
    [MinLength(3)]
    public string? Description { get; set; }
    //Image
    [Required]
    [Column(TypeName = "image")]
    public byte[]? Image { get; set; }
    //Status
    [Required]
    public bool Status { get; set; }
    [AllowNull]
    public virtual Title? Title { get; set; }
}