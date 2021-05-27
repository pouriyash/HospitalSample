using BlazoriseDemo.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoriseDemo.API.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {


        private readonly ILogger<ChartController> _logger;
        private readonly IChartService _chartService;

        public ChartController(ILogger<ChartController> logger, IChartService chartService)
        {
            _logger = logger;
            _chartService = chartService;
        }

        [HttpGet]
        public IActionResult GetChartData(int skip)
        {
            var item = _chartService.GetDataList(skip);
            return Ok(item);
        }

    }
}
