using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.")]
	public class SearchGoal18ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchGoal18ConversionRate" />.
		/// </summary>
		public SearchGoal18ConversionRate(): base("Site Search Goal 18 Conversion Rate",false,"ga:searchGoal18ConversionRate")
		{
			
		}
	}
}

