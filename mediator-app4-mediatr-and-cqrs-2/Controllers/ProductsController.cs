using mediator_app4_mediatr_and_cqrs_2.Commands.AddProduct;
using mediator_app4_mediatr_and_cqrs_2.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace mediator_app4_mediatr_and_cqrs_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Products : ControllerBase
    {
        private readonly IMediator _mediator;

        public Products(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }

        [HttpPost("with-result")]
        public async Task<IActionResult> PostWithResult(AddProductWithResultCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
