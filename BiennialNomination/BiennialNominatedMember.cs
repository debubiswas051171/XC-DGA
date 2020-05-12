using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.BiennialNomination
{
    public class BiennialNominatedMember : NominatedMemberAbstract
    {
        public int BiennialMemberNominationId
        {
            get; set;
        }

        public int MemberId
        {
            get; set;
        }

        public int BiennialHeaderId
        {
            get; set;
        }

        public DateTime? NominatedOn
        {
            get; set;
        }
    }
}
