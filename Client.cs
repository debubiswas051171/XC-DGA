using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using DGALib.IO.Http;
//using IdentityModel.Client;

using System.Web.Security;
using SC = global::Sitecore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using IdentityModel.Client;
using DGA.Take2Rest.IdentityModelExtensions;

//using DGA.Take2Rest.AnnualMeeting;
//using DGA.Take2Rest.BiennialNomination;
//using DGA.Take2Rest.Awards;
//using DGA.Take2Rest.EmployerSearch;
//using DGA.Take2Rest.Login;
//using DGA.Take2Rest.AgencyListing;

namespace DGA.Take2Rest
{
    public static class Client
    {
        static DiscoveryCache _cache = new DiscoveryCache( IdentityURL );
        private static string IdentityURL
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["IdentityURL"];
            }
        }


        private static string API_URL
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
            }

        }

        private static string CLIENT_ID
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ClientId"];
            }

        }

        private static string CLIENT_SECRET
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ClientSecret"];
            }

        }

        private static string SCOPE
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["Scope"];
            }

        }

        private static async Task<DiscoveryResponse> getDisco()
        {
            var disco = await _cache.GetAsync();
            if (disco.IsError)
                throw new Exception(disco.Error);

            return disco;
        }


        private static async Task<IdentityModel.Client.IdentityModelExtensions.TokenResponse> _RetrieveAccessToken(string uName, string pWd)
        {
            var client = new HttpClient();
            IdentityModel.Client.IdentityModelExtensions.TokenResponse tokenResponse = null;
            try
            {
                var disco = await getDisco();

                string[] temp = uName.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                uName = temp.Length > 1 ? temp[1] : temp[0];
                var tokenRequest = new PasswordTokenRequest
                {
                    Address = disco.TokenEndpoint,
                    ClientId = CLIENT_ID,
                    ClientSecret = CLIENT_SECRET,
                    UserName = uName,
                    Password = pWd
                };

                tokenResponse = await client.RequestPasswordTokenAsync(tokenRequest).ConfigureAwait(false);

                if (tokenResponse.IsError)
                    throw new Exception(tokenResponse.Error);


            }
            catch (Exception e)
            {
                throw e;
            }

            return tokenResponse;
        }

        private static async Task<DGATokenResponse> _RetrieveDGAAccessToken(string token)
        {
            var client = new HttpClient();
            DGATokenResponse dgaTokenResponse = null;
            try
            {
                var disco = await getDisco();

                client = new HttpClient();
                client.SetBearerToken(token);
                var resp = client.GetStringAsync(disco.UserInfoEndpoint).Result;

                dgaTokenResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<DGATokenResponse>(resp);

            }
            catch (Exception e)
            {
                throw e;
            }

            return dgaTokenResponse;
        }


        public static IdentityModel.Client.IdentityModelExtensions.TokenResponse RetrieveAccessToken(string login, string password)
        {
            IdentityModel.Client.IdentityModelExtensions.TokenResponse token = null;
            Task.Run(async () => { token = await _RetrieveAccessToken(login, password); }).Wait();
            return token;
        }

        public static DGATokenResponse RetrieveDGAAccessToken(string tokenString)
        {
            DGATokenResponse token = null;
            Task.Run(async () => { token = await _RetrieveDGAAccessToken(tokenString); }).Wait();
            return token;
        }



    }
}
