using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.BiennialNomination
{
    public class NominationElectionDetail
    {
        public int VotingDetailId
        {
            get;
            set;
        }

        public int VotingHeaderId
        {
            get;
            set;
        }

        public string VotingTitle
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public DateTime VotingEndDate
        {
            get;
            set;
        }

        public string TermDescription
        {
            get
            {
                return Term?.TermDescription;
            }
            set
            {
            }
        }

        public Term Term
        {
            get;
            set;
        }
    }
}
