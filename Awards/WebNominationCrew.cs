using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Awards
{
    [Serializable]
    public class WebNominationCrew
    {
        public int? WebNominationCrewSubmissionId { get; set; }
        public int? WebNominationSubmissionId { get; set; }
        public string Category { get; set; }
        public string CrewName { get; set; }

        public int? CommercialNominationId { get; set; }
    }
}
