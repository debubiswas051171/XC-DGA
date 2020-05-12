using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.AgencyListing
{
    public class ContactAddress
    {
        public int ContactAddressId { get; set; }
        public int? CompanyId { get; set; }
        public int? PersonId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? CountryId { get; set; }
        public string Zip { get; set; }
        public string Zip4 { get; set; }
        public bool IsPublic { get; set; }
        public bool IsPrimary { get; set; }
        public string PrimaryPhone { get; set; }
        public int AddressStatusId { get; set; }
    }
}
