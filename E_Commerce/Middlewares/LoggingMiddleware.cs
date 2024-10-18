using Microsoft.AspNetCore.Http.Extensions;
using System.Diagnostics;

namespace E_Commerce.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) 
        {
            var method = context.Request.Method;
            var url = context.Request.GetEncodedUrl();
            var timestamp = DateTime.Now;
            var stopwatch = Stopwatch.StartNew();

            await _next(context);

            stopwatch.Stop();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"Method - {method}, TimeStamp - {timestamp}\nURL - {url}\nDuration - {stopwatch.Elapsed}");
            Console.WriteLine("---------------------------------------------------------------------------");
        }

    }
}
