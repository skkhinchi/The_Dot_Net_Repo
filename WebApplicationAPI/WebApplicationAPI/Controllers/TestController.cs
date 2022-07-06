using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAPI.Controllers
{
    interface IMath
    {
        abstract int Multiply(int a, int b);
        abstract int Divide(int a, int b);
        abstract int Substract(int a, int b);
        abstract int Add(int a, int b);

    }
    class Math : IMath
    {

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        Math obj = new Math();

        [HttpGet]
        public dynamic Get(int a, int b, string c)
        {
            switch(c)
            {
                case "add":
                    {
                        return obj.Add(a, b);
                    }
                case "sub":
                    {
                        return obj.Substract(a, b);
                    }
                case "multi":
                    {
                        return obj.Multiply(a, b);
                    }
                case "div":
                    {
                        return obj.Divide(a, b);
                    }
                default:
                    {
                        return "Something went wrong";
                    }

            }
          
;
        }



    }

}
