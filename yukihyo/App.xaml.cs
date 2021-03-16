using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.SharedTransitions;


namespace yukihyo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new SharedTransitionNavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
