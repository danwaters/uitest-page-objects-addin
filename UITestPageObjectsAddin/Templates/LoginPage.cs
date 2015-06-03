using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ${Namespace}
{
	public class LoginPage : BasePage
	{
		private readonly Query usernameField = e => e.Id ("username");
		private readonly Query passwordField = e => e.Id ("password");
		private readonly Query loginButton = e => e.Id ("btn_login");

		public LoginPage (IApp app)
			: base (app)
		{
			Trait = new Trait (usernameField);
			app.WaitForTrait (Trait);
		}

		public LoginPage LogIn(string username, string password)
		{
			app.WaitForElement (usernameField);
			app.Screenshot ("On the Login page");

			app.EnterText (usernameField, username);
			app.Screenshot ("Enter Username");

			app.EnterText (passwordField, password);
			app.Screenshot ("Enter Password");

			app.Tap (loginButton);
			app.Screenshot ("Tap 'Log In'");

			return this;
		}
	}
}

