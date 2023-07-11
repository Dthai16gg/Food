using System.ComponentModel.DataAnnotations;
using Common.Common.Entity.Entity.Account;
namespace Common.Common.Entity.Entity.Delivery;

public class DeliveryDetails : IEntity.IEntity
{
    public Guid Id { get; set; }
    public Guid ShippingMethodId { get; set; }
    public Guid UserId { get; set; }
    public DateTime DeliveryDate { get; set; }
    public TimeOnly DeliveryTime { get; set; }
    public int Status { get; set; }
    public string? DeliveryAddress { get; set; }
    public string? DeliveryNote { get; set; }
    public string? DeliveryPhoneNumber { get; set; }
    public string? DeliveryEmail { get; set; }
    public string? DeliveryName { get; set; }
    public virtual ShippingMethods? ShippingMethods { get; set; }
    public virtual Accounts? Accounts { get; set; }
}