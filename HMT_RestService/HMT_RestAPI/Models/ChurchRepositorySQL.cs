using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT_RestAPI.Models
{
	public class ChurchRepositorySQL : IChurchRepository
	{
		public List<Church> GetChurches(string searchText)
		{
			List<Church> churches = new List<Church>();
			churches.Add(
				new Church() { Name = "St.George Church Moolamattom", State = "Kerala" }
				);
			churches.Add(
				new Church() { Name = "St.Sebastians Church Neyyassery", State = "Kerala" }
				);

			return churches;
		}
	}
}