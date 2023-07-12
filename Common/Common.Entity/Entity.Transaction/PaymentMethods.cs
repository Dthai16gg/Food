using System.ComponentModel.DataAnnotations;

namespace Common.Common.Entity.Entity.Transaction;

public class PaymentMethods
{
  public Guid Id { get; set; }
  [Required(ErrorMessage = "Name is required")]
  [MaxLength(30, ErrorMessage = "Max Length is 30 letter")]
  public string? Name { get; set; }
  [Required(ErrorMessage = "Description is required")]
  public string? Description { get; set; }
  public List<TransactionReport>? TransactionReports { get; set; }
}
