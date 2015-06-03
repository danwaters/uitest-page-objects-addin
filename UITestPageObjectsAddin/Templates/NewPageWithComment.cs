using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ${Namespace}
{
	public class ${Name} : BasePage
	{
		private readonly Query button = e => e.Id ("button");

		public ${Name} (IApp app)
			: base (app)
		{
			Trait = new Trait (button);
			app.WaitForTrait (Trait);
		}

		public ${Name} TapAButton()
		{
			app.WaitForElement (button);

			app.Tap(button);
			app.Screenshot ("Tap the button");

			return this;
		}

		/*
		 * Cut and paste this code into PageExtensions.cs to load ${Name} from IApp
		 * 

		public static ${Name} ${Name} (this IApp app)
		{
			var page = new ${Name} (app);
			if (app.TraitExists (page.Trait))
				return page;

			throw new Exception ("The Login page was not found.");
		}

		*** End ****/
	}
}

