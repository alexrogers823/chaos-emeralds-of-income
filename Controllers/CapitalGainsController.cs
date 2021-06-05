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
                new CapitalGains{Id=1, Investment="QQQ", CurrentValue=1086.54},
                new CapitalGains{Id=1, Investment="SPGRX", CurrentValue=337.52},
                new CapitalGains{Id=1, Investment="MSFT", CurrentValue=545.22}
            };

            return Ok(capitalGains);
        }
    }
}