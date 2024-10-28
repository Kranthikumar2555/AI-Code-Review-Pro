using System.ComponentModel.DataAnnotations;

namespace CourseManagement.Models;

public class TransferViewModel
{
    
    [Display(Name = "From Account")]
    [Required]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Source Account Number must be exactly 10 digits.")]
    public string? FromAccount { get; set; }

   [Required]
    [Display(Name = "To Account")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Destination Account Number must be exactly 10 digits.")]
    public string? ToAccount { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    [Display(Name = "Transfer Amount")]
    public decimal Amount { get; set; }

   
   [Required]
    [Display(Name = "Description")]
    public string? Description { get; set; }
}
