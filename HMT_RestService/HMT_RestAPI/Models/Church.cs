using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT_RestAPI.Models
{
	public class Church
	{
		public string Name { get; set; }

		public string StreetName { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public List<HolyMass> HolyMasses { get; set; }
	}
}