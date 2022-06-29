// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections.Generic;
using IdentityModel.Client;

namespace Duende.TokenManagement.ClientCredentials;

/// <summary>
/// Client access token options
/// </summary>
public class ClientCredentialsTokenManagementOptions
{
    /// <summary>
    /// Used to prefix the cache key
    /// </summary>
    public string CacheKeyPrefix { get; set; } = "Duende.TokenManagement.Cache";

    /// <summary>
    /// Value to subtract from token lifetime for the cache entry lifetime (defaults to 60 seconds)
    /// </summary>
    public int CacheLifetimeBuffer { get; set; } = 60;
        
    /// <summary>
    /// Configures named client configurations for requesting client tokens.
    /// </summary>
    public IDictionary<string, ClientCredentialsTokenRequest> Clients { get; set; } = new Dictionary<string, ClientCredentialsTokenRequest>();
}