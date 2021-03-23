using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace yukihyo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		/* Navigation */
		async void Tapped(System.Object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new EnterNameView(), false);
		}
	}
}
