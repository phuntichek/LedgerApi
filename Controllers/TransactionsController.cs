using LedgerApi.Models;
using LedgerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LedgerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ILedgerService _ledgerService;

        public TransactionsController(ILedgerService ledgerService)
        {
            _ledgerService = ledgerService;
        }

        [HttpPost]
        public IActionResult CreateTransaction([FromBody] Transaction transaction)
        {
            try
            {
                _ledgerService.AddTransaction(transaction);
                return CreatedAtAction(nameof(GetTransactionById), new { id = transaction.Id }, transaction);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Transaction>> GetAllTransactions()
        {
            var transactions = _ledgerService.GetAllTransactions();
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public ActionResult<Transaction> GetTransactionById(Guid id)
        {
            var transaction = _ledgerService.GetTransactionById(id);

            if (transaction == null)
            {
                return NotFound(new { error = "Transaction not found." });
            }

            return Ok(transaction);
        }
    }
}
