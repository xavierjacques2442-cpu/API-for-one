using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_for_one.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using API_for_one;

namespace API_for_one.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerThree : ControllerBase
    {
    private readonly ServiceThree _serviceThree;
    public ControllerThree(ServiceThree serviceThree)
        {
            _serviceThree = serviceThree;
        }
        [HttpGet]
        [Route("add_2_numbers")]
        public IActionResult AddTwoNumbers([FromQuery] int Number1,[FromQuery] int Number2)
    {
        var result = _serviceThree.AddTwoNumbers(Number1, Number2);
        return Ok(new{Result = result});
    }
    }
}