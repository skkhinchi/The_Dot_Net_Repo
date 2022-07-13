using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Service;
using WebApplicationAPI.Model;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")] //why we use [] bracket
    [ApiController] // why we use

    public class MathOpController : ControllerBase
    {
        private readonly IMathOperations _op;

        //DI
        public MathOpController(IMathOperations op)
        {
            _op = op;
        }

        [Route("Add")]
        [HttpPost]
        //safe way to read parameters from body, findout the meta tags / Identify 
        //Implement validation for params
        //add exception handling for every case 
        //add 2 levels for log, debug log, input log (params ), throw exception
        public ActionResult AddFun(InputValues values)
        {
            return Ok(_op.AddFun(values));
        }


        [Route("Substract")]
        [HttpPost]
        public ActionResult SubFun(InputValues values)
        {
            return Ok(_op.SubFun(values));
        }


        [Route("Multiply")]
        [HttpPost]
        public ActionResult MulFun(InputValues values)
        {
            return Ok(_op.MulFun(values));
        }


        [SampleActionFilter]
        [Route("Divide")]
        [HttpPost]
       
        public ActionResult DivFun(InputValues values)
        {
            return Ok(_op.DivFun(values));
        }

    }
}
