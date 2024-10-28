using CourseManagement.Models;

namespace CourseManagement.Repository;

public interface IAccountRepository
{
    Account? GetAccount(string accountId);
    void Update(Account account);
}