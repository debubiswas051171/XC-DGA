using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.EmployerSearch
{
    public class MemberSearchPagedResult
    {
        public virtual IEnumerable<MemberSearchResult> MemberSearchResults { get; set; }
        public int? WebSearchRequestId { get; set; }
        public PagedCriteria PagedCriteria { get; set; }
        public SortCriteria SortCriteria { get; set; }
    }
}
