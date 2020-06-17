using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogServiceController : ControllerBase
    {
        private readonly ILogger<CatalogServiceController> _logger;

        public CatalogServiceController(ILogger<CatalogServiceController> logger)
        {
            _logger = logger;
        }

    }
}
