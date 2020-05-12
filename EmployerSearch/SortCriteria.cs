using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DGA.Take2Rest.EmployerSearch
{
    [DataContract(Name = "SortExpression", Namespace = "DGA.Take2Rest.EmployerSearch" )]
    public enum SortExpressionEnum
    {
        [EnumMember(Value = "FirstName")]
        FirstName,
        [EnumMember(Value = "LastName")]
        LastName
    }


    [DataContract(Name = "SortOrder", Namespace = "DGA.Take2Rest.EmployerSearch" )]
    public enum SortOrderEnum
    {
        [EnumMember(Value = "Asc")]
        Asc,
        [EnumMember(Value = "Desc")]
        Desc
    }

    public class SortCriteria
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SortExpressionEnum SortExpression { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public SortOrderEnum SortOrder { get; set; }
    }
}
