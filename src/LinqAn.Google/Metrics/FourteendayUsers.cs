using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date.
	/// </summary>
	[Description("Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date.")]
	public class FourteenDayUsers: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FourteenDayUsers" />.
		/// </summary>
		public FourteenDayUsers(): base("14 Day Active Users",false,"ga:14dayUsers")
		{
			
		}
	}
}

