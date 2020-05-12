using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Login
{
    public class UserCredentialChangeRequest
    {
        public string MemberNumber { get; set; }
        public string EmailAddress { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CredentialTypeEnum CredentialType { get; set; }
    }

    [DataContract(Name = "CredentialTypeEnum", Namespace = "DGA.WebAPI.Membership.MembershipProviders.Model")]
    public enum CredentialTypeEnum
    {
        [EnumMember(Value = "Password")]
        Password = 1,
        [EnumMember(Value = "Username")]
        Username = 2,
        [EnumMember(Value = "Both")]
        Both = 3,
        [EnumMember(Value = "NewUser")]
        NewUser = 4,
    }

}
