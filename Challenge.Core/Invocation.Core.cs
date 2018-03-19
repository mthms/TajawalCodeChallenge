using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.Models;
using OpenQA.Selenium;

namespace Challenge.Core
{
	public class Invocation
	{
		public static IWebDriver invokeChrome(Browser targetBrowser)
		{
			IWebDriver ChromeObject = 
				SeleniumInvokationCore.InvokationManagement.InvokeChrome(targetBrowser.getDriverPath());
			return ChromeObject;
		}

		public static IWebDriver invokeFireFox(Browser targetBrowser)
		{
			IWebDriver FireFoxObject =
				SeleniumInvokationCore.InvokationManagement.InvokeFirefox(targetBrowser.getBrowserPath(), 
																		targetBrowser.getDriverPath(), 
																		targetBrowser.getDriverName() + ".exe");
			return FireFoxObject;
		}

		public static IWebDriver invokeIE(Browser targetBrowser)
		{
			IWebDriver IEObject =
				SeleniumInvokationCore.InvokationManagement.InvokeInternetExplorer(targetBrowser.getDriverPath());
			return IEObject;
		}

		public static IWebDriver invokeEdge(Browser targetBrowser)
		{
			IWebDriver EdgeObject =
				SeleniumInvokationCore.InvokationManagement.InvokeEdge(targetBrowser.getDriverPath());
			return EdgeObject;
		}   

		public static IWebDriver invokeOpera(Browser targetBrowser)
		{
			IWebDriver OperaObject =
				SeleniumInvokationCore.InvokationManagement.InvokeOpera(targetBrowser.getBrowserPath(),
																		targetBrowser.getDriverPath(),
																		targetBrowser.getDriverName() + ".exe");
			return OperaObject;
		}	 

		public static IWebDriver invokePhantomJS(Browser targetBrowser)
		{
			IWebDriver PhantomJSObject =
				SeleniumInvokationCore.InvokationManagement.InvokePhantomJS(targetBrowser.getDriverPath(),
																			targetBrowser.getDriverName() + ".exe");
			return PhantomJSObject;
		}
	}
}