using System;
using System.Collections.Generic;

namespace Challenge.TestData
{
	public class TestData
	{
		public static Dictionary<string, string> TestingURLs = new Dictionary<string, string>()
		{
			{"1", "https://www.tajawal.ae"},
			{"2", "https://www.tajawal.com" }
		};
		public static Dictionary<string, string> TestingScenarios = new Dictionary<string, string>()
		{
			{"1", "Scenario1" },
			{"2", "Scenario2" }
		};
		public static string[] originCellData = { "DXB Dubai", "Cairo", "Frankfurt", "SVO Moscow", "PAR Paris" };
		public static string[] DestinationCellData = { "TYO Tokyo", "SYD Sydney", "STM Santarem", "YYZ Toronto", "JNB Johannesburg" };
	}
}
