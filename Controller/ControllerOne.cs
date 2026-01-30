using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_for_one.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerOne : ControllerBase
    {
    [HttpGet]
    [Route("sayHello")]
    public string SayHello([FromQuery] string name)
        {
            return $"hello,{name}!";
        }
    }
}