using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationAPI.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class Math : ControllerBase
    {
        [Route("Welcome")]
        [HttpGet]
        public string Display()
        {
            return "Welcome to DotNet";
        }
       


    }

}
