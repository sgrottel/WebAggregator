using System;
using System.Collections.Generic;
using System.Text;

namespace WebAggregator.Data
{

	/// <summary>
	/// Simple article content, with one featured image, a list of paragraphis (no formatting), and a list of links
	/// </summary>
	public class ArticleContent
	{
		/// <summary>
		/// Featured image
		/// TODO: Clarify format
		/// </summary>
		public object Image { get; set; }

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
