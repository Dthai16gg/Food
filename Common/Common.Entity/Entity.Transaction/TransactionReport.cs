using System.ComponentModel.DataAnnotations;
using Common.Common.Entity.Entity.Account;
using Common.Common.Entity.Entity.Delivery;
using Common.Common.Entity.Entity.Oder;

namespace Common.Common.Entity.Entity.Transaction;

public class TransactionReport : IEntity.IEntity
{
  public Guid Id { get; set; }
  [Required]
  [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
  public DateTime TransactionDate { get; set; }
  public Guid PaymentMethodId { get; set; }
  public Guid DeliveryDetailsId { get; set; }
  public Guid UserId { get; set; }
  [Required(ErrorMessage = "Total Price is required")]
  public decimal TotalPrice { get; set; }
  public int TotalQuantity { get; set; }
  [Required(ErrorMessage = "Status is required")]
  [Range(1, 3, ErrorMessage = "Status is not valid")]
  public int Status { get; set; }
  public virtual DeliveryDetails? DeliveryDetails { get; set; }
  public virtual PaymentMethods? PaymentMethods { get; set; }
  public virtual Accounts? Accounts { get; set; }
  public List<OderDetails>? OderDetails { get; set; }
}
