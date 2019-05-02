using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace eSchool.Presentation
{
    
    [Route("api/[controller]/[action]")]
    public class BaseController:Controller
    {
        private IMediator mediator;

        protected IMediator Processor => mediator ?? (mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}
