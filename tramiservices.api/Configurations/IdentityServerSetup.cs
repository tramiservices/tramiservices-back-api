using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using tramiservices.api.Configurations.IdentityServer;

namespace tramiservices.api.Configurations
{
    internal static class IdentityServerSetup
    {
        internal static IServiceCollection AddIdentityServerSetup(this IServiceCollection services)
        {
            services.AddIdentityServer()
            .AddDeveloperSigningCredential()
            .AddInMemoryApiResources(IdentityServerConfiguration.GetApiResources())
            .AddInMemoryClients(IdentityServerConfiguration.GetClients());
            return services;
        }

        internal static IApplicationBuilder UseIdentityServerSetup(this IApplicationBuilder app)
        {
            app.UseIdentityServer();
            return app;
        }
    }
}
