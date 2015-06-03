using System;
using Xamarin.UITest;

namespace ${Namespace}
{
	public abstract class BasePage
	{
		protected IApp app { get; private set; }
		public Trait Trait { get; protected set; }

		protected BasePage(IApp app)
		{
			this.app = app;
		}
	}
}

