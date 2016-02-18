namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.
	/// </summary>
	public class MonthIndexDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="MonthIndexDimension" />.
		/// </summary>
		public MonthIndexDimension(): base("Month Index","Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.",false,"ga:nthMonth")
		{
			
		}
	}
}

