using System;
using System.Runtime.CompilerServices;

namespace IdentityModel.Client
{
    public class ClientAssertion
    {
        public string Type
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }

        public ClientAssertion()
        {
        }
    }
}