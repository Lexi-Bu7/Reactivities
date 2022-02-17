using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        //Check if the controller has an instance of Imediator available, if so re-use, if not create the instance
        //could use constructor injection here instead
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        
        // public BaseApiController(IMediator mediator)
        // {
        //     Mediator = mediator;
        // }
        // public BaseApiController(){

        // }
        // public IMediator Mediator { get; }
    }
}