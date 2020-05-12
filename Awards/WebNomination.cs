using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.Awards
{
    public class WebNomination
    {
        public int? WebNominationSubmissionId { get; set; }
        public Guid? Identifier { get; set; }
        public string AwardsCategory { get; set; }
        public int? NominationStatusId { get; set; }
        public string DirectorName { get; set; }
        public string DirectorMemberNumber { get; set; }
        public string DirectorContactNumber { get; set; }
        public string DirectorEmailAddress { get; set; }
        public string ProjectTitle { get; set; }
        public string EpisodeTitle { get; set; }
        public string Description { get; set; }
        public string Host { get; set; }
        public int? LengthInMinutes { get; set; }
        public DateTime? OriginalAirDate { get; set; }
        public string IMDBLink { get; set; }
        public string ContactType { get; set; }
        public string ContactName { get; set; }
        public string ContactCompany { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string URLToStream { get; set; }
        public string PWDToAccessStream { get; set; }
        public DateTime? TheatricalReleaseDate { get; set; }
        public DateTime? TheatricalRunEndDate { get; set; }
        public string TheatreChain { get; set; }
        public string TheatreChainPhoneNumber { get; set; }
        public string TheatreChainAddress { get; set; }
        public string DistributionType { get; set; }
        public bool? IsOneDirectorLimitedSeries { get; set; }

        public string Notes { get; set; }

        public bool IsFinalSubmission { get; set; }

        public int? UserId { get; set; }

        public virtual ICollection<WebNominationCrew> Crew { get; set; }

        public virtual ICollection<CommercialNomination> Commercials { get; set; }
    }
}
