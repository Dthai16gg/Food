using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Common.Entity.Entity.Delivery;
using Common.Common.Entity.Entity.Transaction;

namespace Common.Common.Entity.Entity.Account;

public class Accounts : IEntity.IEntity
{
  [Required]
  [Display(Name = "First name")]
  [MaxLength(50, ErrorMessage = "First Name cannot be longer than 50 characters.")]
  public string? FirstName { get; set; }

  [Required]
  [Display(Name = "Last Name")]
  [MaxLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters.")]
  public string? LastName { get; set; }

  [Display(Name = "Full Name")] public string FullName => FirstName + " " + LastName;

  [Required]
  [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$",
      ErrorMessage = "Not a valid email address")]
  [Display(Name = "Email Address")]
  [MaxLength(50, ErrorMessage = "Email Address cannot be longer than 50 characters.")]
  public string? EmailAddress { get; set; }

  public string? Password { get; set; }
  [MaxLength(10, ErrorMessage = "Mobile Phone cannot be longer than 12 characters.")]
  [RegularExpression("^(\\+84|0)\\d{9,10}$", ErrorMessage = "Not a valid phone number")]
  [Display(Name = "Mobile Phone")]
  [Required(ErrorMessage = "Mobile Phone is required")]
  public string? MobilePhone { get; set; }

  [Required(ErrorMessage = "Address is required")]
  [MaxLength(300, ErrorMessage = "Address cannot be longer than 300 characters.")]
  public string? Address { get; set; }

  [Column(TypeName = "image")]
  [Required]
  public required byte[] Avatar { get; set; }

  [Required(ErrorMessage = "GoogleId is required")]
  public string? GoogleId { get; set; }

  [Required(ErrorMessage = "GoogleToken is required")]
  public string? GoogleToken { get; set; }

  [Required(ErrorMessage = "Status is required")]
  public bool Status { get; set; }

  public virtual AuthorRole? AuthorRoles { get; set; }

  [Key] public Guid Id { get; set; }
  public Guid AuthorRoleId { get; set; }
  public List<TransactionReport>? TransactionReports { get; set; }
  public List<DeliveryDetails>? DeliveryDetails { get; set; }
}
