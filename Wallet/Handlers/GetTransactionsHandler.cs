using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Wallet
{
    public class GetTransactionsHandler : IRequestHandler<GetTransactionsQuery, List<TransactionModel>>
    {
        private readonly IDb _db; 
        public GetTransactionsHandler(IDb db)
        {
            _db = db;
        }
        public Task<List<TransactionModel>> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_db.GetTransactions());
        }
    }
}
