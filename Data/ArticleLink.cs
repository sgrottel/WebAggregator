using System;

namespace WebAggregator.Data
{

	/// <summary>
	/// A link within a news article
	/// </summary>
	public class ArticleLink
	{

		/// <summary>
		/// The text to be shown as link
		/// </summary>
		/// <remarks>If null or empty, show `HRef`</remarks>
		public string Text { get; set; } = null;

		/// <summary>
		/// The hyper-link reference uri
		/// </summary>
		public Uri HRef { get; set; }

	}

}