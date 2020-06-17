using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ordering.Domain.OrderAggregate;

namespace Ordering.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderingServiceController : ControllerBase
    {
        private readonly ILogger<OrderingServiceController> _logger;

        public OrderingServiceController(ILogger<OrderingServiceController> logger)
        {
            _logger = logger;
        }
    }
}
