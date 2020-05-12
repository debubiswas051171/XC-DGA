using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.AgencyListing
{
    public class Agency
    {
        public int AgencyId { get; set; }
        public virtual string AgencyName { get; set; }
        public virtual string AgentName { get; set; }
        public virtual ContactAddress AgencyContactAddress { get; set; }
        public virtual string AgencyNameFormatted { get; set; }
    }
}
