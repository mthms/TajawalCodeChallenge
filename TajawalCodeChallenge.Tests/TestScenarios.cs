using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge.Models;
using Challenge.Helpers;
using OpenQA.Selenium;

namespace TajawalCodeChallenge.Tests
{
	[TestClass]
	public class TestScenarios
	{
		[TestMethod]
		public static void FirstScenario(TestCaseModel testCase)
		{
			IWebDriver browserObject = testCase.getBrowserObject();
			SearchModel searchInputs = testCase.GetSearchModel();
			openTargetURL(browserObject, testCase.getURL());
			searchInputs = searchAction_HomePage(browserObject, searchInputs);
		}

		[TestMethod]
		public static void SecondScenario(TestCaseModel testCase)
		{
			IWebDriver browserObject = testCase.getBrowserObject();
			openTargetURL(browserObject, testCase.getURL());
		}

		private static void openTargetURL(IWebDriver browserObject, string Url)
		{
			browserObject.Url = Url;
		}

		private static SearchModel searchAction_HomePage(IWebDriver browserObject, SearchModel searchInputs)
		{
			HomePageModel homePage = new HomePageModel();
			browserObject.FindElement(By.Id(homePage.getOriginCellSelector())).SendKeys(searchInputs.getOrigin());
			browserObject.FindElement(By.Id(homePage.getDestinationCellSelector())).SendKeys(searchInputs.getDestination());
			searchInputs.setStartMonth(browserObject.FindElement(By.XPath(homePage.getDepartureMonthSelector())).Text);
			searchInputs.setStartDay(int.Parse(browserObject.FindElement(By.XPath(homePage.getDepartureDaySelector())).Text));
			searchInputs.setEndMonth(browserObject.FindElement(By.XPath(homePage.getReturnMonthSelector())).Text);
			searchInputs.setEndDay(int.Parse(browserObject.FindElement(By.XPath(homePage.getReturnDaySelector())).Text));
			browserObject.FindElement(By.Id(homePage.getAdultsSelector())).Click();
			browserObject.FindElement(By.XPath(homePage.getAdultsSelectorPlusButton())).Click();
			browserObject.FindElement(By.Id(homePage.getSearchButtonSelector())).Click();
			return searchInputs;
		}
	}
}
