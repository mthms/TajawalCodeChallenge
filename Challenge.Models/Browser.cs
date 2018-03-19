using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Models
{
	public class Browser
	{
		private string Name;
		private string driverName;
		private string driverPath;
		//Setting a default value for the browser that's installation path is not required.
		private string browserPath = @"C:\\Program Files";

		public void setBrowser_Name(string browserName)
		{
			this.Name = browserName;
		}

		public string getBrowserName()
		{
			return Name;
		}

		public void setDriverName(string driverName)
		{
			this.driverName = driverName;
		}

		public string getDriverName()
		{
			return driverName;
		}

		public void setDriverPath(string driverPath)
		{
			this.driverPath = driverPath;
		}

		public string getDriverPath()
		{
			return this.driverPath;
		}

		public void setBrowserPath(string browserPath)
		{
			this.browserPath = browserPath;
		}

		public string getBrowserPath()
		{
			return this.browserPath;
		}
	}
}
