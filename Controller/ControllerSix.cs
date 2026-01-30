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
    public class ControllerSix : ControllerBase
    {
        [HttpGet("Revers")]
   public string Revers(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}