namespace Transact.Models;

public class Transaction
{
    public int? ID { get; set; }
    public DateTime Timestamp { get; set; }
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public int CategoryId { get; set; }
    public string? Comments { get; set; }
}