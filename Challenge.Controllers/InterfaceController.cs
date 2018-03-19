using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.Models;

namespace Challenge.Controllers
{
	public class InterfaceController
	{
		public static void DrawMainConsole()
		{
			String targetbrowser = null;
			Console.WriteLine("Enter the browser name as one of the below \n " +
				"[Chrome, Firefox, IE, Edge, Opera, PhantomJS] \n");
			targetbrowser = Console.ReadLine();
			if (InputController.Validate_BrowserChoice(targetbrowser))
				DrawMainConsole_ValidInput(targetbrowser);
			else
			{
				DrawMainConsole_InvalidInput();
				DrawMainConsole();
			}
		}

		public static void DrawMainConsole_InvalidInput()
		{
			Console.WriteLine("\n You entered an invalid input. Please, try again and read instructions carefully. ...");
			System.Threading.Thread.Sleep(3000);
			Console.Clear();
		}

		public static void DrawMainConsole_ValidInput(String targetbrowser)
		{
			Console.WriteLine("\n");
			Console.Clear();
			Console.WriteLine("Initiating " + targetbrowser + " browser ...");
			Draw_CollectDriverPath(targetbrowser);
		}

		public static void Draw_CollectDriverPath(String targetbrowser)
		{
			Models.Browser targetBrowser = new Models.Browser();
			Console.WriteLine("\n");
			Console.WriteLine("Please, Download the webdriver for your targetted browser from seleniumHQ website then Place it in the below path. \n");
			Console.WriteLine("C:\\Selenium\\Browsers Drivers\n");
			Console.WriteLine("Once done, press enter, please.");
			Console.ReadLine();
			targetBrowser.setBrowser_Name(targetbrowser);
			targetBrowser.setDriverPath("C:\\Selenium\\Browsers Drivers");
			Draw_CollectDriverName(targetBrowser);
		}

		public static void Draw_CollectDriverName(Models.Browser targetBrowser)
		{
			Console.WriteLine("\n");
			Console.WriteLine("Now, to the driver name.\n");
			Console.WriteLine("Please, make sure to have the driver name as below according to each browser.\n");
			foreach (string x in Helpers.BrowsersEntities.BrowsersDriversNames.Keys)
				Console.WriteLine(x + ">>" + Helpers.BrowsersEntities.BrowsersDriversNames[x]);
			Console.WriteLine("Once done, press enter, please.");
			targetBrowser.setDriverName(Helpers.BrowsersEntities.BrowsersDriversNames[targetBrowser.getBrowserName()]);
			Draw_CollectBrowserPath(targetBrowser);
		}

		public static void Draw_CollectBrowserPath(Models.Browser targetBrowser)
		{
			Console.WriteLine("\n");
			Console.WriteLine("Now, to the browser path.\n");
			Console.WriteLine("Please, make sure to have the browser's installation path as below according to each browser. \n");
			Console.WriteLine("**Note: If your selected browser is not mentioned below, then the path is not required and can be any path.");
			foreach (string x in Helpers.BrowsersEntities.BrowsersPaths.Keys)
				Console.WriteLine(x + ">>" + Helpers.BrowsersEntities.BrowsersPaths[x]);
			Console.WriteLine("Once done, press enter, please.");
			if(Helpers.BrowsersEntities.BrowsersPaths.ContainsKey(targetBrowser.getBrowserName()))
				targetBrowser.setBrowserPath(Helpers.BrowsersEntities.BrowsersPaths[targetBrowser.getBrowserName()]);
			Models.TestCaseModel TestCase = new Models.TestCaseModel();
			TestCase.setBrowserObject(InvocationController.CoreAccess_Controller(targetBrowser));
			Draw_UserChoosingURL(TestCase);
		}

		public static void Draw_UserChoosingURL(TestCaseModel TestCase)
		{
			Console.Clear();
			Console.WriteLine("Your browser invoking process completed successfully.\n");
			Console.WriteLine("Please read the below URL and select your targetted one.\n");
			Console.WriteLine("\t 1-" + TestData.TestData.TestingURLs["1"] + "\n");
			Console.WriteLine("\t 2-" + TestData.TestData.TestingURLs["2"] + "\n");
			Console.WriteLine("Your choice number (1 or 2): ");
			string selection = Console.ReadLine();
			if (InputController.Validate_URLSelection(selection))
			{
				TestCase.setURL(TestData.TestData.TestingURLs[selection]);
				Draw_UserChoosingScenarios(TestCase);
			}
			else
			{
				DrawMainConsole_InvalidInput();
				Draw_UserChoosingURL(TestCase);
			}
		}

		public static void Draw_UserChoosingScenarios(TestCaseModel TestCase)
		{
			Console.WriteLine("Please, read the below scenarios and select your targetted one.\n");
			Console.WriteLine("\t 1-" + TestData.TestData.TestingScenarios["1"] + "\n");
			Console.WriteLine("\t 2-" + TestData.TestData.TestingScenarios["2"] + "\n");
			Console.WriteLine("Your choice number (1 or 2): ");
			string selection = Console.ReadLine();
			if (InputController.Validate_ScenarioSelection(selection))
			{
				TestCase.setScenario(TestData.TestData.TestingScenarios[selection]);
				TestController.TestCaseController(TestCase);
			}
			else
			{
				DrawMainConsole_InvalidInput();
				Draw_UserChoosingScenarios(TestCase);
			}
		}
	}
}
