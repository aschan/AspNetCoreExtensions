namespace Aschan.AspNetCore.Http
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public class ClacksMiddleware
    {
        private const string XClacksOverhead = @"X-Clacks-Overhead";
        private const string GnuTerryPrattchet = @"GNU Terry Pratchett";

        private readonly RequestDelegate _next;

        public ClacksMiddleware(RequestDelegate next)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public Task Invoke(HttpContext httpContext)
        {
            if (httpContext==null)
                throw new ArgumentNullException(nameof(httpContext));

            httpContext.Response.Headers.Add(XClacksOverhead, GnuTerryPrattchet);

            return _next(httpContext);
        }
    }
}
