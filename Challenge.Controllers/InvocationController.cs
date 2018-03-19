using Challenge.Models;
using OpenQA.Selenium;

namespace Challenge.Controllers
{
	class InvocationController
	{
		//A function that takes the browser's data and directs it to its' core function.
		//The core function will create the browser object.
		public static IWebDriver CoreAccess_Controller(Browser targetBrowser)
		{
			IWebDriver BrowserObject = null;
			switch (targetBrowser.getBrowserName())
			{
				case "Chrome":
					BrowserObject = Core.Invocation.invokeChrome(targetBrowser);
					break;
				case "Firefox":
					BrowserObject = Core.Invocation.invokeFireFox(targetBrowser);
					break;
				case "IE":
					BrowserObject = Core.Invocation.invokeIE(targetBrowser);
					break;
				case "Edge":
					BrowserObject = Core.Invocation.invokeEdge(targetBrowser);
					break;
				case "Opera":
					BrowserObject = Core.Invocation.invokeOpera(targetBrowser);
					break;
				case "PhantomJS":
					BrowserObject = Core.Invocation.invokePhantomJS(targetBrowser);
					break;
				default:
					break;
			}
			return BrowserObject;
		}
	}
}