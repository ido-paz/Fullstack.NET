using Microsoft.AspNetCore.Mvc.Filters;

    internal class ActionMethodLogger : IActionFilter
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Before : " + context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("After : " + context.ActionDescriptor.DisplayName);
        }
    }
