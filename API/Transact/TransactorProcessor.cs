namespace Transact;

internal class TransactorProcessor
{
    public Queue<ITransactor> Transactions { get; } = new();
    bool _isRunning = false;

    public TransactorProcessor()
    {
        _ = new Timer(
            callback: async _ =>
            {
                if (_isRunning) return;
                try
                {
                    _isRunning = true;
                    await ProcessTransactions();
                }
                finally
                {
                    _isRunning = false;
                }
            },
            state: null,
            dueTime: TimeSpan.FromSeconds(5),
            period: TimeSpan.FromSeconds(5)
        );
    }

    public void AddTransaction(ITransactor transactor)
    {
        Console.WriteLine($"Adding transaction to queue: {transactor.Transaction.ID}");
        Transactions.Enqueue(transactor);
    }

    public async Task ProcessTransactions()
    {
        while (Transactions.TryDequeue(out var transactor))
        {
            Console.WriteLine($"Processing transaction: {transactor.Transaction.ID}");
            await transactor.ProcessTransactionAsync();
            Console.WriteLine($"Transaction processed: {transactor.Transaction.ID}");
        }
    }
}
