using CourseManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagement.Controllers;

public class TransferController : Controller
{
    private readonly IAccountRepository _accountRepository;

    public TransferController(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    [HttpGet]
    public IActionResult Transfer()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Transfer(string fromAccount, string toAccount, decimal amount)
    {
        var from = _accountRepository.GetAccount(fromAccount);
        var to = _accountRepository.GetAccount(toAccount);

        if (from == null || to == null)
        {
            return BadRequest("Invalid account information.");
        }

        try
        {
            from.Debit(amount);
            to.Credit(amount);

            _accountRepository.Update(from);
            _accountRepository.Update(to);
            return RedirectToAction("TransferSuccess");
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public IActionResult TransferSuccess()
    {
        return View();
    }
}



