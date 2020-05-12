using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IdentityModel.Client
{
    public enum ClientCredentialStyle
    {
        AuthorizationHeader,
        PostBody
    }

    public class Request:System.Net.Http.HttpRequestMessage
    {
        public string Address
        {
            get;
            set;
        }

        public BasicAuthenticationHeaderStyle AuthorizationHeaderStyle
        {
            get;
            set;
        }

        public ClientAssertion ClientAssertion { get; set; } = new ClientAssertion();

        public ClientCredentialStyle ClientCredentialStyle { get; set; } = ClientCredentialStyle.PostBody;

        public string ClientId
        {
            get;
            set;
        }

        public string ClientSecret
        {
            get;
            set;
        }

        public IDictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();

        public Request()
        {
        }

        public Request Clone()
        {
            Request request = new Request()
            {
                Address = this.Address,
                AuthorizationHeaderStyle = this.AuthorizationHeaderStyle,
                ClientAssertion = this.ClientAssertion,
                ClientCredentialStyle = this.ClientCredentialStyle,
                ClientId = this.ClientId,
                ClientSecret = this.ClientSecret,
                Parameters = new Dictionary<string, string>()
            };
            if (this.Parameters != null)
            {
                foreach (KeyValuePair<string, string> parameter in this.Parameters)
                {
                    request.Parameters.Add(parameter);
                }
            }
            return request;
        }
    }
}