using Microsoft.AspNetCore.Builder;

namespace MicroserviceBase.Api
{
    public static class CorrelationTokenMiddlewareExtensions
    {
        public static IApplicationBuilder AddCorrelationToken(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<CorrelationTokenMiddleware>();
        }

    }
}
