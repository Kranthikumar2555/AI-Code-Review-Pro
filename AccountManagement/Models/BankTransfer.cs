namespace CourseManagement.Models;

public class BankTransfer
{
    public int TransferId { get; set; }
    public int FromAccountId { get; set; }
    public int ToAccountId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransferDate { get; set; }
    public string? Status { get; set; }
}
