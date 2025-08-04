using Microsoft.AspNetCore.Mvc;

namespace ActionSelectorsandReturnValues.Controllers
{
	public class HomeController
	{
		public string Index()
		{
			return "Home Index Called!";
		}

		[ActionName("Cal")]
		public string CalculateValueUsingBinaryClassificationGuassianAlgorithm()
		{
			return "Value Calculated!";
		}

		[NonAction]
		public string NotForCall()
		{
			return "Not For Call";
		}
	}
}
