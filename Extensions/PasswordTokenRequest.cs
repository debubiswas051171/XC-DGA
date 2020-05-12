using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace IdentityModel.Client
{
    //
    // Summary:
    //     Request for token using password
    public class PasswordTokenRequest : TokenRequest
    {
        public PasswordTokenRequest() { }

        //
        // Summary:
        //     Gets or sets the password.
        public string Password { get; set; }
        //
        // Summary:
        //     Gets or sets the scope.
        public string Scope { get; set; }
        //
        // Summary:
        //     Gets or sets the name of the user.
        public string UserName { get; set; }
    }
}