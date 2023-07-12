using System.ComponentModel.DataAnnotations;
using Common.Common.Entity.Entity.Account;

namespace Common.Common.Entity.Entity.Oder;

public class Oder : IEntity.IEntity
{
  public Guid Id { get; set; }
  [Required]
  public Guid UserId { get; set; }
  public virtual Accounts? Accounts { get; set; }
  public List<OderDetails>? OderDetails { get; set; }
}
