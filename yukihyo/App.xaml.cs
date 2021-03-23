using System;
using Xamarin.Forms;
using yukihyo.Objects;
using Xamarin.Forms.Xaml;
using Plugin.SharedTransitions;


namespace yukihyo
{
	public partial class App : Application
	{
		private TimeKeeper timeKeeper = new TimeKeeper();
		private TimeKeeperHunger timeKeeperHunger = new TimeKeeperHunger();
		private TimeKeeperHabitat timeKeeperHabitat = new TimeKeeperHabitat();
		private TimeKeeperSafety timeKeeperSafety = new TimeKeeperSafety();

		public App()
		{
			InitializeComponent();
			MainPage = new SharedTransitionNavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
			Console.WriteLine("OnStart");

			Console.WriteLine(timeKeeper.StoredTime);
			Console.WriteLine(timeKeeper.GetTimeElapsed());
		}

		protected override void OnSleep()
		{
			Console.WriteLine("OnSleep");

			timeKeeper.StoredTime = DateTime.Now;
			timeKeeperHunger.StoredTime = DateTime.Now;
			timeKeeperHabitat.StoredTime = DateTime.Now;
			timeKeeperSafety.StoredTime = DateTime.Now;
		}

		protected override void OnResume()
		{
			Console.WriteLine("OnResume");

			Console.WriteLine(timeKeeper.StoredTime);
			Console.WriteLine(timeKeeper.GetTimeElapsed());
		}
	}
}
