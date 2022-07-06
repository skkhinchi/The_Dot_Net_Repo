using Microsoft.AspNetCore.Mvc;


namespace WebApplicationAPI.Controllers
{
    interface IMath
    {
        abstract int Multiply(int a, int b);
        abstract int Divide(int a, int b);
        abstract int Substract(int a, int b);
        abstract int Add(int a, int b);

    }
   
    [ApiController]
    [Route("[controller]")]
    public class Math : ControllerBase, IMath
    {
        [Route("Welcome")]
        [HttpGet]
        public string Display()
        {
            return "Welcome to DotNet";
        }
        [Route("Multiply")]
        [HttpPost]
        public int Multiply(int a, int b)
        {
            return a * b;
        }


        [SampleActionFilter]
        [Route("Divide")]
        [HttpPost]
        public int Divide(int a, int b)
        {
            return a / b;
        }

        [Route("Substract")]
        [HttpPost]
        public int Substract(int a, int b)
        {
            return a - b;
        }

        [Route("Add")]
        [HttpPost]
        public int Add(int a, int b)
        {
            return a + b;
        }




    }

}
