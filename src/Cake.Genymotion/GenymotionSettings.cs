using System;
using Cake.Core.Tooling;

namespace Cake.Genymotion
{
	/// <summary>
	/// Contains common settings used by <see cref="Genymotion{TSettings}" />.
	/// </summary>
	public abstract class GenymotionSettings : ToolSettings
    {
		/// <summary>
		/// Gets or sets a value indicating whether to not enable verbose output.
		/// </summary>
		public bool Verbose { get; set; }

		/// <summary>
		/// Gets or sets a value indicating the maximum amount of time (in seconds) the tool should run for before timing out.
		/// </summary>
		public int Timeout { get; set;}
    }
}