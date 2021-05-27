using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Wallet
{
    /* #TA02 */  
    public record CreateTransactionCommand(decimal Amount, string Note) : IRequest<TransactionModel>;
}
