using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace mywebapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "The two most important days in your life are the day you are born and the day you find out why. ~ Mark Twain",
                                  "Eighty percent of success is showing up. ~ Woody Allen" ,
                                  "Believe you can and you’re halfway there. ~ Theodore Roosevelt"};
        }
    }
}