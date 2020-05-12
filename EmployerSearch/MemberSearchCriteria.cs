using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.EmployerSearch
{
    public class MemberSearchCriteria
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<MemberCategory> MemberCategoryList { get; set; }

        public bool IsWomen { get; set; }

        public bool IsMinority { get; set; }

        public string City { get; set; }

        public string StateCode { get; set; }

        public string Zip { get; set; }

        public int? CountryId { get; set; }

        public int? ProductionCenterLocationId { get; set; }

        public string MemberQualificationKey { get; set; }

        public int? UserId { get; set; }

        public int? WebSearchRequestId { get; set; }

        public bool IsGeoSearch { get; set; }

        public string MemberName { get; set; }

        public SortCriteria SortCriteria { get; set; }

        public PagedCriteria PagedCriteria { get; set; }
    }
}
