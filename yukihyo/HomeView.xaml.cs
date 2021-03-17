using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yukihyo.Objects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yukihyo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            updateUI();
        }

        /*Navigation*/
        async void TappedOnMenu(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuView(), false);
        }

        private Yukihyo yukihyo = new Yukihyo();

        /*Update UI Name*/
        void updateUI()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                if (yukihyoNameLabel.Text != yukihyo.YukihyoName)
                {
                    yukihyoNameLabel.Text = yukihyo.YukihyoName;
                }
            });
        }
    }
}