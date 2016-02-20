namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second
    ///     week, and so on. The index corresponds to week entries.
    /// </summary>
    public class WeekIndex : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="WeekIndex" />.
        /// </summary>
        public WeekIndex()
            : base(
                "Week Index",
                "Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.",
                false, "ga:nthWeek")
        {
        }
    }
}