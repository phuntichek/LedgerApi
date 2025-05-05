using LedgerApi.Models;

namespace LedgerApi.Services
{
    public interface ILedgerService
    {
        void AddTransaction(Transaction transaction);
        decimal GetCurrentBalance();
        IEnumerable<Transaction> GetAllTransactions();
        Transaction? GetTransactionById(Guid id);
    }
}
