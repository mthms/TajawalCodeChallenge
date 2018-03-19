using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Controllers
{
	public class InputController
	{
		public static Boolean Validate_BrowserChoice(string targetBrowser)
		{
			String[] browsers = { "Chrome", "Firefox", "IE", "Edge", "Opera", "PhantomJS" };
			if (browsers.Contains(targetBrowser))
				return true;
			else
				return false;
		}

		public static Boolean Validate_URLSelection(string selection)
		{
			if (TestData.TestData.TestingURLs.ContainsKey(selection))
				return true;
			else
				return false;
		}

		public static Boolean Validate_ScenarioSelection(string selection)
		{
			if (TestData.TestData.TestingScenarios.ContainsKey(selection))
				return true;
			else
				return false;
		}
	}
}
