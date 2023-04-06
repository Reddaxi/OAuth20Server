/*
                        GNU GENERAL PUBLIC LICENSE
                          Version 3, 29 June 2007
 Copyright (C) 2022 Mohammed Ahmed Hussien babiker Free Software Foundation, Inc. <https://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.
 */

using System.Collections.Generic;

namespace OAuth20.Server.Models
{
    public class ClientStore
    {
        public IEnumerable<Client> Clients = new[]
        {
            new Client
            {
                ClientName = "DOS3 Umbraco",
                ClientId = "dos3id",
                ClientSecret = "dos3secret",
                AllowedScopes = new[]{ "openid", "profile", "blazorWasmapi.readandwrite", "email" },
                GrantType = GrantTypes.Code,
                IsActive = true,
                ClientUri = "https://localhost:44373",
                RedirectUri = "https://localhost:44373/signin-oidc",
                UsePkce = true,
            },
            new Client
            {
                ClientName = "TestProject",
                ClientId = "platformnet6",
                ClientSecret = "123456789",
                AllowedScopes = new[]{ "openid", "profile", "blazorWasmapi.readandwrite" },
                GrantType = GrantTypes.Code,
                IsActive = true,
                ClientUri = "https://localhost:7026",
                RedirectUri = "https://localhost:7026/signin-oidc",
                UsePkce = false,
            }
        };
    }
}
