using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace API_for_one.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerFive : ControllerBase
    {
        [HttpGet("check-number")]
        public IActionResult CheckNumber([FromQuery] int number)
        {
            bool IsOdd = number % 2 != 0;

            return Ok(new{IsOdd = IsOdd});
        }
}
}
