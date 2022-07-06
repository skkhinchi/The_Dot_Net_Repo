
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;

namespace WebApplicationAPI
{
    public class SampleActionFilter : ActionFilterAttribute, IActionFilter
    {
        public void onException(ExceptionContext exceptionContext)
        {
              throw new DivideByZeroException();
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
            throw new DivideByZeroException();

        }

        public void OnActionExecuting(ActionExecutedContext filtercontext)
        {
            throw new DivideByZeroException();
            // Do something after the action executes.
        }
    }

}
