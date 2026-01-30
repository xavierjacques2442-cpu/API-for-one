using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace API_for_one.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerFour : ControllerBase
    {
     private readonly MadLab _madLab;

        public ControllerFour(MadLab madLab)
        {
            _madLab = madLab;
        }
        [HttpGet("generate-madlib")]
        public IActionResult GenerateMadLib(
        
            [FromQuery] string name,
            [FromQuery] string adjective1,
            [FromQuery] string adjective2,
            [FromQuery] string noun1,
            [FromQuery] string noun2,
            [FromQuery] string verb1,
            [FromQuery] string verb2,
            [FromQuery] string adverb,
            [FromQuery] string place,
            [FromQuery] string emotion
        )
    
        {
            var madLib = _madLab.GenerateMadLib(
                name,
                adjective1,
                adjective2,
                noun1,
                noun2,
                verb1,
                verb2,
                adverb,
                place,
                emotion
            );

            return Ok(madLib);
        }
    }

    public class MadLab
    {
        public object GenerateMadLib(string name, string adjective1, string adjective2, string noun1, string noun2, string verb1, string verb2, string adverb, string place, string emotion)
        {
            throw new NotImplementedException();
        }
    }
}
    
