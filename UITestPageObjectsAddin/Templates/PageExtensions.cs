using System;
using Xamarin.UITest;

namespace ${namespace}
{
	public static class PageExtensions
	{
		public static ${Name} ${Name}(this IApp app)
		{
			var page = new ${Name} (app);
			if (app.TraitExists(page.Trait))
				return page;

			throw new Exception ("The ${Name} page was not found.");
		}

		public static LoginPage LoginPage(this IApp app)
		{
			var page = new LoginPage (app);
			if (app.TraitExists(page.Trait))
				return page;

			throw new Exception ("The Login page was not found.");
		}

		// Add more methods here to get new page objects from IApp.
	}
}

