using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class TransactionDb : IDb
    {

        private readonly List<TransactionModel> transactions = new();

        public TransactionDb()
        {
            transactions.Add(new() { Id = 1, Amount = 10.0m, Note = "deposit" });
            transactions.Add(new() { Id = 2, Amount = -10.0m, Note = "withdraw" });
        }

        public TransactionModel CreateTransaction(decimal amount, string note)
        {
            var nextId = transactions.Max(tx => tx.Id) + 1;

            TransactionModel tx = new() { Id = nextId, Amount = amount, Note = note };
            transactions.Add(tx);

            return tx;

        }

        public List<TransactionModel> GetTransactions()
        {
            return transactions.ToList();
        }
    }
}
