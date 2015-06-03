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
	}
}

