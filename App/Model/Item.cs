using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace SG.WebAggregator.Model
{
	class Item
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public Url Link { get; set; }
		public DateTime PublicationTime { get; set; }
		/// <summary>
		/// Formatted content, HTML or MD or something
		/// </summary>
		public string Content { get; set; }
	}
}
