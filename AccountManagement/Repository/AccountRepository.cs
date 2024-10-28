
using CourseManagement.Models;

namespace CourseManagement.Repository;
public class AccountRepository : IAccountRepository
{
    private readonly BankContext _context;

    public AccountRepository(BankContext context)
    {
        _context = context;
    }

    public Account? GetAccount(string accountId)
    {
        return _context.Accounts.Find(accountId);
    }

    public void Update(Account account)
    {
        _context.Update(account);
        _context.SaveChanges();
    }
}
