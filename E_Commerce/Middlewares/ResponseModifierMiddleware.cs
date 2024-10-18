namespace E_Commerce.Middlewares
{
    public class ResponseModifierMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseModifierMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var name = GetType().Name;
            var timestamp = DateTime.Now;

            context.Response.Headers["Middleware-name"] = name;
            context.Response.Headers["Timestamp"] = timestamp.ToString();

            await _next(context);
        }
    }
}
