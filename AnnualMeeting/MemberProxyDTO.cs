using System;
using System.Collections.Generic;
using System.Text;

namespace DGA.Take2Rest.AnnualMeeting
{
	public class MemberProxyDTO
	{
		public int MemberId
		{
			get; set;
		}

		public int EventYear
		{
			get; set;
		}

		public int? PrimaryProxyId
		{
			get; set;
		}

		public int? SecondaryProxyId
		{
			get; set;
		}

		public string PrimaryMemberName
		{
			get; set;
		}

		public string SecondaryMemberName
		{
			get; set;
		}

		public string Excuse
		{
			get; set;
		}

		public bool IsAttending
		{
			get; set;
		}
	}
}
