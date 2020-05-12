using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.BiennialNomination
{
    public class BiennialVoteCounter
    {
        public int VotesCast
        {
            get; set;
        }

        public int MaxNumberOfVotes
        {
            get; set;
        }

        public bool IsSelfNominated
        {
            get;set;
        }
    }
}
