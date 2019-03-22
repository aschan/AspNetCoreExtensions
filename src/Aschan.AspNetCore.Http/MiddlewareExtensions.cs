namespace Aschan.AspNetCore.Http
{
    using System;

    using Microsoft.AspNetCore.Builder;

    /// <summary>
    /// Extension methods to add capabilities to an HTTP application pipeline.
    /// </summary>
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// Adds the <see cref="T:Aschan.AspNetCore.Http.ClacksMiddleware"/> to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />, which writes an X-Clacks-Overhead response header to the response.
        /// </summary>
        /// <param name="applicationBuilder">The IApplicationBuilder to add the middleware to.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <remarks> GNU Terry Pratchett (http://www.gnuterrypratchett.com/).</remarks>
        public static IApplicationBuilder UseClacks(this IApplicationBuilder applicationBuilder)
        {
            if (applicationBuilder == null)
                throw new ArgumentNullException(nameof(applicationBuilder));

            return applicationBuilder.UseMiddleware<ClacksMiddleware>();
        }
    }
}
