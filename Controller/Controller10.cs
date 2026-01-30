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
    public class Controller10 : ControllerBase
    {
    private readonly service10 _service10;

public Controller10(service10 service10)
{
    _service10 = service10;
}
        [HttpGet("pick")]
public IActionResult Pick([FromQuery] string cuisinePicker)
        {
        if (string.IsNullOrWhiteSpace(cuisinePicker))
        {
            return Ok(new
            {
                question = "Please provide a cuisine type to pick from.",
                choices = _service10.GetCategories(),
                example = "/api/controller10/pick?cuisinePicker=Italian"
            });
        }

            try
            {   
        var restaurant = _service10.Pick(cuisinePicker);
                return Ok(new
                {
                    category = cuisinePicker,
                    restaurant = restaurant
                });
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
}
    }
}
