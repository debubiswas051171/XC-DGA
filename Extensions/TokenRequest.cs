using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
    public class TokenRequest : Request
    {
        public string GrantType
        {
            get;
            set;
        }

        public TokenRequest()
        {
        }
    }
}