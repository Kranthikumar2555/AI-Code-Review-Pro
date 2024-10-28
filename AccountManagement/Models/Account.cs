namespace CourseManagement.Models;
public class Account
{
    public int Id { get; set; }
    public string? AccountNumber { get; set; }
    public string? AccountHolder { get; set; }
    public decimal Balance { get; set; }

    public void Debit(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
    }

     public void Credit(decimal amount)
    {
        Balance += amount;
    }

}
