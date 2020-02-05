using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace tramiservices.api.Configurations
{
    internal static class CorsSetup
    {
        internal static IServiceCollection AddCorsSetup(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("TramiservicesPolicy",
                builder => builder.WithOrigins("http://localhost:4200"));
            });
            return services;
        }

        internal static IApplicationBuilder UseCorsSetup(this IApplicationBuilder app)
        {
            app.UseCors("TramiservicesPolicy");
            return app;
        }
    }
}
