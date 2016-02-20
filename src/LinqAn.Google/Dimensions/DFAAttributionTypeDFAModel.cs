namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google
    ///     Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the
    ///     Google Analytics session was an ad impression, then the value will be ViewThrough (premium only).
    /// </summary>
    public class DFAAttributionTypeDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAttributionTypeDFAModel" />.
        /// </summary>
        public DFAAttributionTypeDFAModel()
            : base(
                "DFA Attribution Type (DFA Model)",
                "There are two possible values: ClickThrough and ViewThrough. If the last DCM event associated with the Google Analytics session was a click, then the value will be ClickThrough. If the last DCM event associated with the Google Analytics session was an ad impression, then the value will be ViewThrough (premium only).",
                false, "ga:dcmLastEventAttributionType")
        {
        }
    }
}