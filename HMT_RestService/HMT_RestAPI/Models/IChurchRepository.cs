using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMT_RestAPI.Models
{
	public interface IChurchRepository
	{
		List<Church> GetChurches(string searchText);
	}
}
