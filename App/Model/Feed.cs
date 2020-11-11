using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace SG.WebAggregator.Model
{
	class Feed
	{
		public string Title { get; set; }
		public Url Link { get; set; }
		public string Description { get; set; }

		#region optionals
		public object Icon { get; set; }
		public object MetaData { get; set; }
		public TimeSpan RefreshRate { get; set; }
		#endregion
	}
}
