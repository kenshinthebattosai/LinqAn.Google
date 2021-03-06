using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the requested custom dimension, where 37 refers the number/index of the custom dimension.
	/// </summary>
	[Description("The name of the requested custom dimension, where 37 refers the number/index of the custom dimension.")]
	public class Dimension37: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Dimension37" />.
		/// </summary>
		public Dimension37(): base("Custom Dimension 37",true,"ga:dimension37")
		{
			
		}
	}
}

