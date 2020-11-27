using System;

namespace WebAggregator.Data
{

	/// <summary>
	/// A news article
	/// </summary>
	public class Article
	{

		/// <summary>
		/// Maschine-readable local unique id
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Human-readable title
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Referenced origin sourc link
		/// </summary>
		public Uri Link { get; set; }

		/// <summary>
		/// Last publication date or update date
		/// </summary>
		public DateTime PublicationTime { get; set; }

		/// <summary>
		/// Featured image
		/// </summary>
		public ArticleImage Image { get; set; }

		/// <summary>
		/// List of text paragraphs
		/// </summary>
		public string[] Paragraphs { get; set; }

		/// <summary>
		/// List of links
		/// </summary>
		public ArticleLink[] Links { get; set; }

	}

}
