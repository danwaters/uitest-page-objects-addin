using System;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ${Namespace}
{
	public static partial class AppExtensions
	{
		public static AppResult[] WaitForElementContainingText(this IApp app, string substring)
		{
			var rawQuery = string.Format ("* {{text CONTAINS '{0}'}}", substring);
			return app.WaitForElement (e => e.Raw (rawQuery));
		}

		public static void Screenshot(this IApp app, string format, params object[] args)
		{
			app.Screenshot (string.Format (format, args));
		}

		public static bool TraitExists(this IApp app, Trait trait)
		{
			try
			{
				var results = app.WaitForTrait(trait);
				return results.Any();
			}
			catch 
			{
				return false;
			}

		}

		public static AppResult[] WaitForTrait(this IApp app, Trait trait, TimeSpan? timeout = null)
		{
			if (timeout == null)
				timeout = TimeSpan.FromSeconds (30);
			
			var results = app.WaitForElement (trait.Query, "Timed out waiting for this page's trait.", timeout);
			return trait.CheckSubstring ? 
				results.Where (e => e.Text.Contains (trait.MatchText)).ToArray () 
					: results;
		}
	}
}

