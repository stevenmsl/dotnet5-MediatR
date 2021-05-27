using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace Wallet
{
    public record GetTransactionByIdQuery(int Id) : IRequest<TransactionModel>; 
   
}
