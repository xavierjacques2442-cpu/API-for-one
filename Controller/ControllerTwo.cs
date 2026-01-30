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
    public class ControllerTwo : ControllerBase
    {
     private readonly ServiceTwo _serviceTwo;

     public ControllerTwo(ServiceTwo serviceTwo)
    {
        _serviceTwo = serviceTwo;
    }
    [HttpGet]
    [Route("ask_2_Questions")]
    public IActionResult ask_2_Questions([FromQuery] string name, [FromQuery] string WakeUpTime)
        {
        var result = _serviceTwo.ask_2_Questions(name, WakeUpTime);
        return Ok(new{Result = result});
        }
    }
}