using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.
	/// </summary>
	[Description("Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.")]
	public class NthWeek: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NthWeek" />.
		/// </summary>
		public NthWeek(): base("Week Index",false,"ga:nthWeek")
		{
			
		}
	}
}

