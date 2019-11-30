using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test.Logging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            /* Asp.net 기본 로그 공급자(Provider)
            _logger.LogError("----------------------------------------------------------");
            _logger.LogError("This is Error Log Test");
            _logger.LogError("----------------------------------------------------------");
            */

            Serilog.Log.Logger.Error("----------------------------------------------------------");
            Serilog.Log.Logger.Error("This is Error Log Test");
            Serilog.Log.Logger.Error("----------------------------------------------------------");

            return new string[] { "value1", "value2" };
        }        
    }
}
