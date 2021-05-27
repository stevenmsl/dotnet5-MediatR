using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public interface IDb
    {

        List<TransactionModel> GetTransactions();
        TransactionModel CreateTransaction(decimal amount, string note);
    }
}
