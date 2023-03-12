using Microsoft.AspNetCore.Mvc.Filters;

public class AddHeaderFilter : IResultFilter
{
    public void OnResultExecuted(ResultExecutedContext context)
    {
           
    }

    public void OnResultExecuting(ResultExecutingContext context)
    {
        context.HttpContext.Response.Headers.Add("Author", "Ido paz");
    }
}
