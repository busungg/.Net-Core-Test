using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.DependencyInjection.Services.Interface;

namespace Test.DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IEnumerable<IDependency> _dependency;
        private readonly IDependency2 _dependency2;

        public ValuesController(ILogger<ValuesController> logger, IEnumerable<IDependency> dependency,
            IDependency2 dependency2)
        {
            _logger = logger;
            _dependency = dependency;
            _dependency2 = dependency2;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            foreach(var obj in _dependency)
            {
                _logger.LogDebug("-----------------------------------------");
                _logger.LogDebug(obj.log("api/values/ HttpGet"));
                _logger.LogDebug("-----------------------------------------");
            }

            if(_dependency2 != null)
            {
                _logger.LogDebug("-----------------------------------------");
                _logger.LogDebug(_dependency2.log("api/values/ HttpGet"));
                _logger.LogDebug("-----------------------------------------");
            }

            return new string[] { "value1", "value2" };
        }
    }
}
