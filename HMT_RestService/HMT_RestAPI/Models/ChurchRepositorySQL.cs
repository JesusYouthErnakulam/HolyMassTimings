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
			return new List<Church>();
		}
	}
}