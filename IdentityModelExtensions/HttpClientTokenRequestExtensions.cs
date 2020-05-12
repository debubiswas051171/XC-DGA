// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityModel.Internal;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.Client.IdentityModelExtensions;

namespace IdentityModel.Client
{
    /// <summary>
    /// HttpClient extensions for OAuth token requests
    /// </summary>
    public static class HttpClientTokenRequestExtensions
    {
        /// <summary>
        /// Sends a token request using the password grant type.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public static async Task<IdentityModel.Client.IdentityModelExtensions.TokenResponse> RequestPasswordTokenAsync(this HttpMessageInvoker client, PasswordTokenRequest request, CancellationToken? cancellationToken = null)
        {
            var clone = request.Clone();

            clone.Parameters.AddRequired(OidcConstants.TokenRequest.GrantType, OidcConstants.GrantTypes.Password);
            clone.Parameters.AddRequired(OidcConstants.TokenRequest.UserName, request.UserName);
            clone.Parameters.AddRequired(OidcConstants.TokenRequest.Password, request.Password, allowEmpty: true);
            clone.Parameters.AddOptional(OidcConstants.TokenRequest.Scope, request.Scope);

            return await client.RequestTokenAsync(clone, cancellationToken).ConfigureAwait(false);
        }

        internal static async Task<IdentityModel.Client.IdentityModelExtensions.TokenResponse> RequestTokenAsync(this HttpMessageInvoker client, ProtocolRequest request, CancellationToken? cancellationToken)
        {
            request.Prepare();
            request.Method = HttpMethod.Post;
            
            HttpResponseMessage response;
            try
            {
                response = await client.SendAsync(request, cancellationToken.HasValue? cancellationToken.Value:new CancellationToken()).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                return ProtocolResponse.FromException<IdentityModel.Client.IdentityModelExtensions.TokenResponse>(ex);
            }

            return await ProtocolResponse.FromHttpResponseAsync<IdentityModel.Client.IdentityModelExtensions.TokenResponse>(response).ConfigureAwait(false);
        }
    }
}