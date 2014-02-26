using HMT_RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMT_RestAPI.Controllers
{
    public class SearchController : ApiController
    {
		IChurchRepository _churchRepository;

		public SearchController() : this(new ChurchRepositorySQL())
		{
		}

		public SearchController(IChurchRepository churchRepository)
		{
			_churchRepository = churchRepository;
		}
		
		public IEnumerable<Church> GetChurches([FromUri]string searchText)
		{
			IEnumerable<Church> churches = _churchRepository.GetChurches(searchText);

			return churches;
		}
    }
}