using IdentityModel.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
    public static class HttpClientTokenRequestExtensions
    {
        public static async Task<TokenResponse> RequestPasswordTokenAsync(this HttpMessageInvoker client, PasswordTokenRequest request, CancellationToken? cancellationToken=null)
        {
            Request request1 = request.Clone();
            request1.Parameters.AddRequired("grant_type", "password", false);
            request1.Parameters.AddRequired("username", request.UserName, false);
            request1.Parameters.AddRequired("password", request.Password, true);
            request1.Parameters.AddOptional("scope", request.Scope);
            ConfiguredTaskAwaitable<TokenResponse> configuredTaskAwaitable = HttpClientTokenRequestExtensions.RequestTokenAsync(client, request1, cancellationToken).ConfigureAwait(false);
            return await configuredTaskAwaitable;
        }

        public static async Task<TokenResponse> RequestTokenAsync(this HttpMessageInvoker client, TokenRequest request, CancellationToken? cancellationToken = null)
        {
            Request request1 = request.Clone();
            if (!request1.Parameters.ContainsKey("grant_type"))
            {
                request1.Parameters.AddRequired("grant_type", request.GrantType, false);
            }
            ConfiguredTaskAwaitable<TokenResponse> configuredTaskAwaitable = HttpClientTokenRequestExtensions.RequestTokenAsync(client, request1, cancellationToken).ConfigureAwait(false);
            return await configuredTaskAwaitable;
        }

        //internal static async Task<TokenResponse> RequestTokenAsync(HttpMessageInvoker client, Request request, CancellationToken? cancellationToken = null)
        //{
        //    HttpClientTokenRequestExtensions.<RequestTokenAsync>d__6 variable = new HttpClientTokenRequestExtensions.<RequestTokenAsync>d__6();
        //    variable.client = client;
        //    variable.request = request;
        //    variable.cancellationToken = cancellationToken;
        //    variable.<>t__builder = AsyncTaskMethodBuilder<TokenResponse>.Create();
        //    variable.<>1__state = -1;
        //    variable.<>t__builder.Start < HttpClientTokenRequestExtensions.<RequestTokenAsync>d__6>(ref variable);
        //    return variable.<>t__builder.Task;
        //}

        internal static async Task<TokenResponse> RequestTokenAsync(HttpMessageInvoker client, Request request, CancellationToken cancellationToken)
        {

            HttpResponseMessage response;
            try
            {
                response = await client.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return await ProtocolResponse.FromHttpResponseAsync<TokenResponse>(response).ConfigureAwait();
        }
    }
}