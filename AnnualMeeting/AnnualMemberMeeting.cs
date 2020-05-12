using System;
using System.Collections.Generic;
using System.Text;

namespace DGA.Take2Rest.AnnualMeeting
{
	public class AnnualMemberMeeting
	{
		public string Location
		{
			get; set;
		}

		public string Address
		{
			get; set;
		}

		public string StartDate
		{
			get; set;
		}

		public string StartTime
		{
			get; set;
		}

		public string RegistrationTime
		{
			get; set;
		}

		public string Deadline
		{
			get; set;
		}

		public DateTime? ExpirationDate
		{
			get; set;
		}

		public bool IsExpired
		{
			get; set;
		}

        public int? ProxyBoardMemberId1 { get; set; }
        public int? ProxyBoardMemberId2 { get; set; }
        public string ProxyBoardPosition1 { get; set; }
        public string ProxyBoardPosition2 { get; set; }
        public string ProxyBoardMemberName1 { get; set; }
        public string ProxyBoardMemberName2 { get; set; }

    }
}
