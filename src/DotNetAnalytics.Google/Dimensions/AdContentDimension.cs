namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	When using manual campaign tracking, the value of the utm_content campaign tracking parameter. When using AdWords autotagging, the first line of the text for your online Ad campaign. If you are using mad libs for your AdWords content, this field displays the keywords you provided for the mad libs keyword match. Otherwise the value is (not set)
	/// </summary>
	public class AdContentDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdContentDimension" />.
		/// </summary>
		public AdContentDimension(): base("Ad Content","When using manual campaign tracking, the value of the utm_content campaign tracking parameter. When using AdWords autotagging, the first line of the text for your online Ad campaign. If you are using mad libs for your AdWords content, this field displays the keywords you provided for the mad libs keyword match. Otherwise the value is (not set)",true,"ga:adContent")
		{
			
		}
	}
}

