using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.BiennialNomination
{
    public class BiennialNominationVote
    {
        public int BiennialNominationVoteId { get; set; }
        public int BiennialHeaderId { get; set; }
        public int NomineeMemberId { get; set; }
        public int NominatorMemberId { get; set; }
        public DateTime NominatedOn { get; set; }
        public int? UserId { get; set; }
        public string NomineeFullName { get; set; }
        public string NominatorFullName { get; set; }
        public bool IsSelfNominated { get; set; }
    }
}
