using System.ComponentModel.DataAnnotations;
using Common.Common.Entity.Entity.Account;
using Common.Common.Entity.Entity.Transaction;
namespace Common.Common.Entity.Entity.Delivery;

public class DeliveryDetails : IEntity.IEntity
{
  public Guid Id { get; set; }
  public Guid ShippingMethodId { get; set; }
  public Guid UserId { get; set; }
  [Required(ErrorMessage = "Delivery Date is required")]
  public DateTime DeliveryDate { get; set; }
  [Required(ErrorMessage = "Delivery Time is required")]
  public DateTime DeliveryTime { get; set; }
  [Required(ErrorMessage = "Status is required")]
  public int Status { get; set; }
  [Required(ErrorMessage = "Delivery Address is required")]
  public string? DeliveryAddress { get; set; }
  [Required(ErrorMessage = "Delivery Note is required")]
  public string? DeliveryNote { get; set; }
  [Required(ErrorMessage = "Delivery Phone Number is required")]
  public string? DeliveryPhoneNumber { get; set; }
  [Required(ErrorMessage = "Delivery Email is required")]
  public string? DeliveryEmail { get; set; }
  [Required(ErrorMessage = "Delivery Name is required")]
  public string? DeliveryName { get; set; }
  public virtual ShippingMethods? ShippingMethods { get; set; }
  public virtual Accounts? Accounts { get; set; }
  public virtual List<TransactionReport>? TransactionReports { get; set; }
}
