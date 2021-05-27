using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR; 

namespace Wallet
{
    public class GetTransactionByIdHandler : IRequestHandler<GetTransactionByIdQuery, TransactionModel>
    {

        private readonly IMediator _mediator; 
        public GetTransactionByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<TransactionModel> Handle(
            GetTransactionByIdQuery request, 
            CancellationToken cancellationToken)
        {
            /* #TA04 */
            var transactions = await _mediator.Send(new GetTransactionsQuery(), CancellationToken.None);

            var transaction = transactions.FirstOrDefault(tx => tx.Id == request.Id);

            return transaction;

        }
    }
}
