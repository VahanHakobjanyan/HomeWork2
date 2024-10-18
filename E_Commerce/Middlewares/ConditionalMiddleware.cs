namespace E_Commerce.Middlewares
{
    public class ConditionalMiddleware
    {
        private readonly RequestDelegate _next;

        public ConditionalMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Method.ToLower() == "get")
            {
                context.Request.Headers["Middleware-name"] = GetType().Name;

                await _next(context);
            }

            await _next(context);
        }
    }
}
