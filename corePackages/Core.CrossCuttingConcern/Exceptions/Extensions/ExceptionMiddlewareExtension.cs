using Core.CrossCuttingConcern.Exceptions.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Core.CrossCuttingConcern.Exceptions.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}