using System.Collections.Generic;
using IdentityServer4.Models;

namespace AuthorizationServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource> 
            {
                new ApiResource("scope.readaccess", "HOSv3 API"),
                new ApiResource("scope.fullaccess", "HOSv3 API"),
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> 
            {
                new Client 
                {
                    ClientId = "HOSv3ReadOnly",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("Info99Gum".Sha256()) },
                    AllowedScopes = { "scope.readaccess"}
                },
                new Client 
                {
                    ClientId = "HOSv3ReadWrite",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("Info99Gum".Sha256()) },
                    AllowedScopes = { "scope.fullaccess"}
                }
            };
        }
    }
}