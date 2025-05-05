using LedgerApi.Models;

namespace LedgerApi.Services
{
    public class LedgerService : ILedgerService
    {
        private readonly List<Transaction> _transactions = new();

        public void AddTransaction(Transaction transaction)
        {
            if (transaction.Amount <= 0)
                throw new ArgumentException("Amount must be positive.");

            if (transaction.Type == TransactionType.Withdrawal && transaction.Amount > GetCurrentBalance())
                throw new InvalidOperationException("Insufficient balance.");

            _transactions.Add(transaction);
        }

        public decimal GetCurrentBalance()
        {
            return _transactions.Sum(t => t.Type == TransactionType.Deposit ? t.Amount : -t.Amount);
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _transactions.AsReadOnly();
        }

        public Transaction? GetTransactionById(Guid id)
        {
            return _transactions.FirstOrDefault(t => t.Id == id);
        }
    }
}
