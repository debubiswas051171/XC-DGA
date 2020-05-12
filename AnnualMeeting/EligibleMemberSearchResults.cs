using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGA.Take2Rest.BiennialNomination;

namespace DGA.Take2Rest.AnnualMeeting
{
    public class EligibleMemberSearchResults
    {
        public IEnumerable<EligibleMemberSearchResult> EligibleSearchResults
        {
            get;
            set;
        }

        public int TotalCount
        {
            get;
            set;
        }
    }
}
