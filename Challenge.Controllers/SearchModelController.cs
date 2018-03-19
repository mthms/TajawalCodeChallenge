using Challenge.Models;
using Challenge.Helpers;

namespace Challenge.Controllers
{
	class SearchModelController
	{
		public static SearchModel createSearchModel()
		{
			SearchModel searchModel = new SearchModel();
			searchModel.setOrigin(SearchModelHelpers.generateRandomOrigin());
			searchModel.setDestination(SearchModelHelpers.generateRandomDestination());
			return searchModel;
		}
	}
}
