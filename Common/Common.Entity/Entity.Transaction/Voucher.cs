using System.ComponentModel.DataAnnotations;
using Common.Common.Entity.Entity.Oder;

namespace Common.Common.Entity.Entity.Transaction;

public class Voucher
{
  public Guid Id { get; set; }
  [Required(ErrorMessage = "Name is required")]
  public string? Name { get; set; }
  public float Discount { get; set; }
  public DateTime TimeStart { get; set; }
  public DateTime TimeEnd { get; set; }
  public bool Status { get; set; }
  public List<TransactionReport>? TransactionReports { get; set; }
}
