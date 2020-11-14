using System;
using System.Collections.Generic;
using System.Text;

namespace WebAggregator.Data
{
	/// <summary>
	/// A feed of news articles
	/// </summary>
	public class Feed
	{

		/// <summary>
		/// Maschine-readable unique Id of the whole feed
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Human-readable title of the whole feed
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Referenced origin link of the whole feed
		/// </summary>
		public Uri Link { get; set; }

		/// <summary>
		/// Human-readable text description of the whole feed (no format support)
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Graphical favicon of the feed; At least 16x16 px in size. Additional sizes possible.
		/// TODO: clarify format
		/// </summary>
		public object Icon { get; set; }

		/// <summary>
		/// Type id of the aggregator to use to fill the feed
		/// </summary>
		public string AggregatorType { get; set; }

		/// <summary>
		/// The source for the aggregator to collect the feed data, e.g. an uri
		/// </summary>
		public string AggregatorSource { get; set; }

		/// <summary>
		/// Update refresh rate to invoke the aggregator
		/// </summary>
		public TimeSpan AggregatorRate { get; set; }

		/// <summary>
		/// Generic settings for the aggregator
		/// </summary>
		public Dictionary<string, string> AggregatorSettings { get; set; }

	}

}
