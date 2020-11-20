using System;

namespace WebAggregator.Data
{
	/// <summary>
	/// A news article
	/// </summary>
	public class Article
	{
		/// <summary>
		/// Maschine-readable local unique id of the article
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Human-readable title of the article
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Referenced origin link of the article
		/// </summary>
		public Uri Link { get; set; }

		/// <summary>
		/// Last publication date or update date of the article
		/// </summary>
		public DateTime PublicationTime { get; set; }

		/// <summary>
		/// Article content
		/// </summary>
		public ArticleContent Content { get; set; }

	}

}
