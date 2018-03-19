using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Models
{
	public class HomePageModel
	{
		private string originCellSelector = "flights-search-origin-1";
		private string DestinationCellSelector = "flights-search-destination-1";
		private string AdultsSelector = "flights-search-open-pax-btn";
		private string DepartureMonthSelector = "/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/section/div/div[1]/form/div[2]/div/div[2]/div[1]/p/span[1]";
		private string DepartureDaySelector = "//*[@id=\"cmsContentServer\"]/div[1]/div[2]/div[2]/section/div/div[1]/form/div[2]/div/div[2]/div[1]/p/span[2]";
		private string ReturnMonthSelector = "//*[@id=\"cmsContentServer\"]/div[1]/div[2]/div[2]/section/div/div[1]/form/div[2]/div/div[2]/div[2]/p/span[1]";
		private string ReturnDaySelector = "//*[@id=\"cmsContentServer\"]/div[1]/div[2]/div[2]/section/div/div[1]/form/div[2]/div/div[2]/div[2]/p/span[2]";
		private string AdultsSelectorPlusButton = "/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/section/div/div[1]/form/div[3]/div[1]/div[3]/div[2]/div[1]/div[2]/a[2]";
		private string SearchButtonSelector = "flights-search-cta";

		public string getOriginCellSelector()
		{
			return this.originCellSelector;
		}
		public string getDestinationCellSelector()
		{
			return this.DestinationCellSelector;
		}
		public string getAdultsSelector()
		{
			return this.AdultsSelector;
		}
		public string getDepartureMonthSelector()
		{
			return this.DepartureMonthSelector;
		}
		public string getDepartureDaySelector()
		{
			return this.DepartureDaySelector;
		}
		public string getReturnMonthSelector()
		{
			return this.ReturnMonthSelector;
		}
		public string getReturnDaySelector()
		{
			return this.ReturnDaySelector;
		}
		public string getAdultsSelectorPlusButton()
		{
			return this.AdultsSelectorPlusButton;
		}
		public string getSearchButtonSelector()
		{
			return this.SearchButtonSelector;
		}
	}
}
