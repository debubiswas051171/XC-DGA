using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.IdentityModelExtensions
{
    public class DGATokenResponse
    {
        public string role { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string email { get; set; }
        public string sub { get; set; }
    }
}
