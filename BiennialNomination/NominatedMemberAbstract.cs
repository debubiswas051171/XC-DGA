using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGA.Take2Rest.BiennialNomination
{
    public abstract class NominatedMemberAbstract
    {
        public bool IsSelfNominated
        {
            get;
            set;
        }

        public bool AlreadyNominated
        {
            get;
            set;
        }

        public bool IsValidated
        {
            get;
            set;
        }

        public int NominationStageTypeId
        {
            get;
            set;
        }

        public int? UserId
        {
            get;
            set;
        }

        public bool ShouldSendEmail
        {
            get
            {
                return !AlreadyNominated && !IsSelfNominated && IsValidated;
            }
        }
    }
}
