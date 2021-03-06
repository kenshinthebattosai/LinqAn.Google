using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which the requested goal number was abandoned.
	/// </summary>
	[Description("The rate at which the requested goal number was abandoned.")]
	public class Goal17AbandonRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal17AbandonRate" />.
		/// </summary>
		public Goal17AbandonRate(): base("Goal 17 Abandonment Rate",false,"ga:goal17AbandonRate")
		{
			
		}
	}
}

