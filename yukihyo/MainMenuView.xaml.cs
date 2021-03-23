using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yukihyo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuView : ContentPage
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        async void ExitMenuTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void HomeTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomeView(), false);
        }

        async void HabitatTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HabitatView(), false);
        }

        async void FeedTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedView(), false);
        }

        async void SafetyTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SafetyView(), false);
        }

        async void ManualTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CareGuideView(), false);
        }

        async void RenameTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new RenameView(), false);
        }

        async void AttentionTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new AttentionView(), false);
        }


    }
}