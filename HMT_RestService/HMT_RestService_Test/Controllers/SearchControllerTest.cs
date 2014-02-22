using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HMT_RestAPI.Controllers;
using HMT_RestAPI.Models;
using System.Collections.Generic;
using HMT_RestService_Test.Models;

namespace HMT_RestService_Test.Controllers
{
	[TestClass]
	public class SearchControllerTest
	{
		[TestMethod]
		public void Controller_should_return_churches_on_search()
		{
			//Get Controller reference
			SearchController sc = new SearchController(new ChurchRepositoryMock());
			//Call controller method
			List<Church> churches = sc.GetChurches("palai");
			//verify the result from above step
			Assert.IsNotNull(churches);
			Assert.AreEqual(churches[0].State, "Kerala");
		}
	}
}
