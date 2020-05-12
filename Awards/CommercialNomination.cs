using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Awards
{
    [Serializable]
    public class CommercialNomination
    {
        public int? CommercialNominationId { get; set; }
        public int? WebNominationSubmissionId { get; set; }
        public string Title { get; set; }
        public string ProductName { get; set; }
        public int? LengthInSeconds { get; set; }
        public string ProductionCompany { get; set; }
        public string Agency { get; set; }
        public string Client { get; set; }
        public DateTime? FirstAirDate { get; set; }

        public virtual ICollection<WebNominationCrew> Crew { get; set; }
    }
}
