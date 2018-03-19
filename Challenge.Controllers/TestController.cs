using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.Models;
using TajawalCodeChallenge.Tests;

namespace Challenge.Controllers
{
	public class TestController
	{
		public static void TestCaseController(TestCaseModel testCase)
		{
			testCase.setSearchModel(SearchModelController.createSearchModel());
			if (testCase.getScenario().Equals("Scenario1"))
			{
				TestScenarios.FirstScenario(testCase);
			}
			else if (testCase.getScenario().Equals("Scenario2"))
			{
				TestScenarios.SecondScenario(testCase);
			}
		}
	}
}
