using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_for_one.Service;
using Microsoft.AspNetCore.Mvc;


namespace API_for_one.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerSeven : ControllerBase
    {

private readonly ServiceSeven _numberReverse;
        private ServiceSeven? numberReverse;

        public ControllerSeven(ServiceSeven _numberReverse)
{
    _numberReverse = numberReverse;
}


        [HttpGet("reversedNumber/{input}")]
        public IActionResult ReverseNumber(string input)
        {
            var result = _numberReverse.ReverseNumber(input);
            return Ok(result);
        }
    }
}