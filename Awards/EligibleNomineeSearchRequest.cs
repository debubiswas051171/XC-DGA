using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Awards
{
    public class EligibleNomineeSearchRequest
    {
        public int? UserId
        {
            get;
            set;
        }

        public int VotingDetailId
        {
            get;
            set;
        }
        public string MemberName
        {
            get;
            set;
        }

        public PagedCriteria pageCriteria
        {
            get;
            set;
        }
    }
}
