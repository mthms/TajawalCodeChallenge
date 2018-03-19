using System;
using System.Collections.Generic;

namespace Challenge.Helpers
{
	public class BrowsersEntities
	{
		public static Dictionary<String, String> BrowsersDriversNames = new Dictionary<string, string>()
		{
			{"Firefox", "geckodriver" },
			{"Opera", "operadriver" },
			{"PhantomJS", "phantomjs" },
			{"Edge", "MicrosoftWebDriver" },
			{"IE", "IEDriverServer"},
			{"Chrome", "chromedriver" }
		};

		public static Dictionary<String, String> BrowsersPaths = new Dictionary<string, string>()
		{
			{"Firefox", @"C:\Program Files\Mozilla Firefox\firefox.exe" },
			{"Opera", @"C:\Program Files\Opera\51.0.2830.55\opera.exe" }
		};
	}
}