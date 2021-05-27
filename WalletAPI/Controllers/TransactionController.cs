using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediatR;
using Wallet;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WalletAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public TransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<TransactionController>
        [HttpGet]
        public async Task<List<TransactionModel>> Get()
        {
            /* #TA02 */
            return await _mediator.Send(new GetTransactionsQuery());
        }

        // GET api/<TransactionController>/5
        [HttpGet("{id}")]
        public async Task<TransactionModel> Get(int id)
        {
            return await _mediator.Send(new GetTransactionByIdQuery(id));
        }

        // POST api/<TransactionController>
        [HttpPost]
        public async Task<TransactionModel> Post([FromBody] TransactionModel value)
        {
            var command = new CreateTransactionCommand(value.Amount, value.Note);
            /* #TA02 */
            return await _mediator.Send(command);
        }


    }
}
