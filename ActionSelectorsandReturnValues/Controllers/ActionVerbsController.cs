using Microsoft.AspNetCore.Mvc;

namespace ActionSelectorsandReturnValues.Controllers
{
	public class ActionVerbsController
	{

		[HttpPost]
		public string SayHello(string id)
		{
			return "Say Hello 1 Called!";
		}

		[HttpGet]
		public string SayHello()
		{
			return "Say Hello 2 Called!";
		} 
	}
}
