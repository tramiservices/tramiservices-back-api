using IdentityServer4.Models;
using System.Collections.Generic;

namespace tramiservices.api.Configurations.IdentityServer
{
    public class IdentityServerConfiguration
    { 
        // Clients allowed to access resources from Auth Server
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "TramiservicesClient",
                    ClientName = "Tramiservices client credentials API",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256())},
                    AllowedScopes = {"api1"}
                }
            };
        }

        // APIs allowed to access the Auth server
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource> { new ApiResource("api1", "Tramiservices Client") };
        }
    }
}
