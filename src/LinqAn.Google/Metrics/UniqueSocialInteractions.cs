using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget.
	/// </summary>
	[Description("The number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget.")]
	public class UniqueSocialInteractions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UniqueSocialInteractions" />.
		/// </summary>
		public UniqueSocialInteractions(): base("Unique Social Actions",false,"ga:uniqueSocialInteractions")
		{
			
		}
	}
}

