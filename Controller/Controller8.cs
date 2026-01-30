using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_for_one.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API_for_one.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Controller8: ControllerBase
    {

        private readonly service8 service8;
        public Controller8(service8 service8)
        {
            service8 = service8;
        }
        [HttpGet("eightball")]
        public ActionResult GetEightBallResponse([FromQuery] string? question)
        {

        if (string.IsNullOrWhiteSpace(question))
        {
            return Ok(new
            {
                question = "Please ask a yes/no question to receive an eight ball response.",
                example = "/api/controller8/GetEightBallResponse?question=Will%20I%20be%20lucky%20today?"
            });
        }

    var response = service8.GetRandomResponse();
            return Ok(new
            {
                question = question,
                response = response
            });
}
        }
}
    