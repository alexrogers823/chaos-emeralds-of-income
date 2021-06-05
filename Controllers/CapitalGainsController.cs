using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/capitalGains")]
    public class CapitalGainsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CapitalGains> GetCapitalGains()
        {
            var capitalGains = new List<CapitalGains>
            {
                new CapitalGains{Id=1, Investment="QQQ", Value=1086.54},
                new CapitalGains{Id=1, Investment="SPGRX", Value=337.52},
                new CapitalGains{Id=1, Investment="MSFT", Value=545.22}
            };

            return Ok(capitalGains);
        }
    }
}