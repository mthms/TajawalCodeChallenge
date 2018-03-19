using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Models
{
	public class SearchModel
	{
		private string Origin;
		private string Destination;
		private string StartMonth;
		private int StartDay;
		private string EndMonth;
		private int EndDay;
		private int AdultsNumber = 2;
		private string FlightClass = "Economy";

		public void setOrigin(string Origin)
		{
			this.Origin = Origin;
		}

		public string getOrigin()
		{
			return this.Origin;
		}

		public void setDestination(string Destination)
		{
			this.Destination = Destination;
		}

		public string getDestination()
		{
			return this.Destination;
		}

		public void setStartMonth(string startMonth)
		{
			this.StartMonth = startMonth;
		}

		public string getStartmonth()
		{
			return this.StartMonth;
		}

		public void setStartDay(int startDay)
		{
			this.StartDay = startDay;
		}

		public int getStartDay()
		{
			return this.StartDay;
		}

		public void setEndMonth(string endMonth)
		{
			this.EndMonth = endMonth;
		}

		public string getEndMonth()
		{
			return this.EndMonth;
		}

		public void setEndDay(int EndDay)
		{
			this.EndDay = EndDay;
		}

		public int getEndDay()
		{
			return this.EndDay;
		}

		public void setAdultsNumber(int AdultsNumber)
		{
			this.AdultsNumber = AdultsNumber;
		}

		public int getAdultsNumber()
		{
			return this.AdultsNumber;
		}

		public void setFlightClass(string FlightClass)
		{
			this.FlightClass = FlightClass;
		}

		public string getFlightClass()
		{
			return this.FlightClass;
		}
	}
}
