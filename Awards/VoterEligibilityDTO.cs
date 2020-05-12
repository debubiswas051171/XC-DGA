using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Awards
{
    public class VoterEligibilityDTO
    {
        public string Title
        {
            get;
            set;
        }

        public string Message { get; set; }

        public string VotingURL
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public DateTime EndDate
        {
            get;
            set;
        }

        public int VotingDetailId
        {
            get;
            set;
        }

        public string EligibilityType
        {
            get; set;
        }
    }
}
