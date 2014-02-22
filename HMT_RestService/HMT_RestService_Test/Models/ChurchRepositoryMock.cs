using HMT_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMT_RestService_Test.Models
{
	public class ChurchRepositoryMock : IChurchRepository
	{
		public List<Church> GetChurches(string searchText)
		{
			List<Church> churches = new List<Church>();
			churches.Add(
				new Church() { Name="St.George Church Moolamattom", State="Kerala"}
				);
			churches.Add(
				new Church() { Name = "St.Sebastians Church Neyyassery", State = "Kerala" }
				);

			return churches;
		}
	}
}
