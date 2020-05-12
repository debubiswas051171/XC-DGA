using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Login
{
    public class UserCredentialChangeResult
    {
        public bool IsValid
        {
            get; set;
        }

        public bool IsLocked
        {
            get; set;
        }

        public Guid? MemberGUID
        {
            get; set;
        }
    }
}
