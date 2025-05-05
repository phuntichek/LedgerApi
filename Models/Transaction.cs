namespace LedgerApi.Models
{
    public class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
    }
}
