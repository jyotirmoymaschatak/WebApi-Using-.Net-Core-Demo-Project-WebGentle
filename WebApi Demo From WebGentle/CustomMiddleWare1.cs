using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Demo_From_WebGentle
{
    public class CustomMiddleWare1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from New MiddleWareFile - 1 \n");
            await next(context); // will call the next middleware
            await context.Response.WriteAsync("Hello from New MiddleWareFile - 2 \n");
        }
    }
}
