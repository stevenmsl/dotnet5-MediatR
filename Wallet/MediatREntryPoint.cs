using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    /* #TA01
      - allows MediatR DI to find commands, queries, and 
        handlers in this project
      - for example in your api project you would configure
        the MediatR DI like this
        - services.AddMediatR(typeof(MediatREntryPoint).Assembly);
    */
    public class MediatREntryPoint
    {
    }
}
