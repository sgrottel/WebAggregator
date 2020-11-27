using System;
using System.Collections.Generic;
using System.Text;

namespace WebAggregator.Data
{

	/// <summary>
	/// The featured image of a news article
	/// </summary>
	public class ArticleImage
	{

		/// <summary>
		/// Image data uri
		/// </summary>
		public Uri Uri { get; set; }

		/// <summary>
		/// Recommended image width in pixel
		/// </summary>
		/// <remarks>A value of zero (or negative) indicates that the information is missing</remarks>
		public double Width { get; set; } = 0.0;

		/// <summary>
		/// Recommended image height in pixel
		/// </summary>
		/// <remarks>A value of zero (or negative) indicates that the information is missing</remarks>
		public double Height { get; set; } = 0.0;

	}

}
