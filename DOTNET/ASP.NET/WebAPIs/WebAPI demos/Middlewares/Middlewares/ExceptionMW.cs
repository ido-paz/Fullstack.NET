namespace Products_WebAPI.Middlewares
{
    public class ExceptionMW
    {
        RequestDelegate _Next;
        public ExceptionMW(RequestDelegate next)
        {
            _Next = next;
        }

        public async Task Invoke(HttpContext ctx)
        {
            try
            {
                await _Next(ctx);
            }
            catch (Exception e)
            {
                ctx.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await ctx.Response.WriteAsync(e.Message);
            }
        }

    }
}
