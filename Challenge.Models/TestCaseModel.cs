using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Challenge.Models
{
	public class TestCaseModel
	{
		private string URL;
		private string scenario;
		private SearchModel SearchData;
		private IWebDriver BrowserObject;

		public void setURL(string URL)
		{
			this.URL = URL;
		}

		public string getURL()
		{
			return this.URL;
		}

		public void setScenario(string scenario)
		{
			this.scenario = scenario;
		}

		public string getScenario()
		{
			return this.scenario;
		}

		public void setSearchModel(SearchModel searchRandomCollection)
		{
			this.SearchData = searchRandomCollection;
		}

		public SearchModel GetSearchModel()
		{
			return this.SearchData;
		}

		public void setBrowserObject(IWebDriver BrowserObject)
		{
			this.BrowserObject = BrowserObject;
		}

		public IWebDriver getBrowserObject()
		{
			return this.BrowserObject;
		}
	}
}
