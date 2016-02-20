namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The day of the month. A two-digit number from 01 to 31.
    /// </summary>
    public class DayOfTheMonth : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DayOfTheMonth" />.
        /// </summary>
        public DayOfTheMonth()
            : base("Day of the month", "The day of the month. A two-digit number from 01 to 31.", false, "ga:day")
        {
        }
    }
}