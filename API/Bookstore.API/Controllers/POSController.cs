using Bookstore.API.Services;
using Bookstore.Models.DTOs.StoreMerch;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.API.Controllers;

[Route("pos")]
[ApiController]
public class POSController(ProcessPurchaseService processPurchaseService) : ControllerBase
{
    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("POS Controller is working");
    }

    [HttpPost("store")]
    public async Task<IActionResult> StorePurchase(PurchaseStoreMerchDTO purchaseStoreMerchDTO)
    {
        await processPurchaseService.ProcessStorePurchasePurchase(purchaseStoreMerchDTO);
        return Ok();
    }
}
