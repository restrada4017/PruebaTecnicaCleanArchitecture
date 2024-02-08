﻿using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private ISender _mediator = null!;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
