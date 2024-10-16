using System.Diagnostics;

namespace E_Commerce.Middlewares
{
    public class ResponseTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            // Call the next middleware in the pipeline
            await _next(context);

            stopwatch.Stop();
            var responseTime = stopwatch.ElapsedMilliseconds;

            // Add the response time to the response headers
            if(!context.Response.HasStarted)
            {
                context.Response.Headers["X-Response-Time-ms"] = responseTime.ToString();
            }
        }
    }
}
