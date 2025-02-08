using Bookstore.API.Services;
using Bookstore.Models.DTOs.StoreMerch;
using Bookstore.Transact;
using Microsoft.AspNetCore.Mvc;
using Transact.Models;

namespace Bookstore.API.Controllers;

[ApiController]
[Route("transact")]
public class TransactController(
    ILogger<TransactController> logger,
    IBookstoreTransactRepository transactRepository
) : ControllerBase
{
    private readonly ILogger<TransactController> _logger = logger;

    [HttpGet("recent-transactions")]
    public async Task<ActionResult<IEnumerable<Transaction>>> GetRecentTransactions()
    {
        _logger.LogInformation("Getting transactions");
        var transactions = await transactRepository.GetTransactionsAsync(DateTime.Now.AddDays(-7), DateTime.Now);
        return Ok(transactions);
    }
}
