using LedgerApi.Models;
using LedgerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LedgerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BalanceController : ControllerBase
    {
        private readonly ILedgerService _ledgerService;

        public BalanceController(ILedgerService ledgerService)
        {
            _ledgerService = ledgerService;
        }

        [HttpGet]
        public ActionResult<BalanceResponse> GetBalance()
        {
            var balance = _ledgerService.GetCurrentBalance();
            return Ok(new BalanceResponse { Balance = balance });
        }
    }
}
