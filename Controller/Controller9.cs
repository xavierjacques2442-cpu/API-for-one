using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_for_one.Services;

namespace API_for_one.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Controller9 : ControllerBase
    {
        private readonly service9 _service9;

        public Controller9(service9 service9)
        {
            _service9 = service9;
        }
       
        [HttpGet("easy")]
        public IActionResult Easy([FromQuery] int number)
        {
            if (number < 1 || number > 10)
            {
                return BadRequest("Number must be between 1 and 10.");
            }
            return Ok(_service9.Guess(number, 10));
        }
        
        [HttpGet("middle")]
        public IActionResult Middle([FromQuery] int number)
        {
            if (number < 1 || number > 50)
            {
                return BadRequest("Number must be between 1 and 50.");
            }
            return Ok(_service9.Guess(number, 50));
           
        }

        [HttpGet("hard")]
        public IActionResult Hard([FromQuery] int number)
        {
            if (number < 1 || number > 100)
            {
                return BadRequest("Number must be between 1 and 100.");
            }
            return Ok(_service9.Guess(number, 100));
    }
    }
}