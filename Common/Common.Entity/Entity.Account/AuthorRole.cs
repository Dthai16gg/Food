using System.ComponentModel.DataAnnotations;

namespace Common.Common.Entity.Entity.Account;

public class AuthorRole : IEntity.IEntity
{
  [Required(ErrorMessage = "RoleName is required")]
  [MaxLength(20, ErrorMessage = "Max Length is 20 letter")]
  [MinLength(3, ErrorMessage = "Min Length is 3 letter")]
  public string? RoleName { get; set; }
  [Required(ErrorMessage = "Id is required")]
  public Guid Id { get; set; }
  public List<Accounts>? Accounts { get; set; }
}
