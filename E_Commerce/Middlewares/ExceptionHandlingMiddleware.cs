using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using System.Text.Json;

namespace E_Commerce.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Status code: " + context.Response.StatusCode);
                context.Response.Headers["Status code"] = context.Response.StatusCode.ToString();
                var exception = new
                {
                    exceptionType = ex.GetType().ToString(),
                    message = ex.Message,
                    trace = ex.StackTrace,
                    date = DateTime.Now,
                };

                var json = JsonSerializer.Serialize(exception); 
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filePath = Path.Combine(desktopPath, $"ExceptionLog_{DateTime.UtcNow:yyyyMMdd_HHmmss}.json");
                File.WriteAllText(filePath, json);
            }
        }
    }
}

