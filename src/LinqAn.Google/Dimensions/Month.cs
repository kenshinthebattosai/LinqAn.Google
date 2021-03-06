using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The month of the session. A two digit integer from 01 to 12.
	/// </summary>
	[Description("The month of the session. A two digit integer from 01 to 12.")]
	public class Month: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Month" />.
		/// </summary>
		public Month(): base("Month of the year",false,"ga:month")
		{
			
		}
	}
}

