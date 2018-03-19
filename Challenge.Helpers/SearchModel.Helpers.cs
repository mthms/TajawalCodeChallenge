using System;

namespace Challenge.Helpers
{
	public class SearchModelHelpers
	{
		private static int randomElementHelper(int length)
		{
			Random random = new Random();
			return random.Next(length);
		}
		public static string generateRandomOrigin()
		{
			return TestData.TestData.originCellData[randomElementHelper(TestData.TestData.originCellData.Length)];
		}

		public static string generateRandomDestination()
		{
			return TestData.TestData.DestinationCellData[randomElementHelper(TestData.TestData.DestinationCellData.Length)];
		}

	}
}
