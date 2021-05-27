using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

namespace Wallet
{
    /* #TA03
       - specify which command or query you want to handle
       - you need to return what the command or query 
         instructs you to return
     */
    public class CreateTransactionHandler : IRequestHandler<CreateTransactionCommand, TransactionModel>
    {
        private readonly IDb _db;
        public CreateTransactionHandler(IDb db)
        {
            _db = db;
        }

        public Task<TransactionModel> Handle(
                CreateTransactionCommand request, 
                CancellationToken cancellationToken
            )
        {
            return Task.FromResult(_db.CreateTransaction(request.Amount, request.Note));
        }
       
    }
}
