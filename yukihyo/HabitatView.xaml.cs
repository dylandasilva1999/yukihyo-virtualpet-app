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
    public partial class HabitatView : ContentPage
    {
        private Yukihyo yukihyo = new Yukihyo();

        public HabitatView()
        {
            InitializeComponent();
            updateUI();
        }

        async void TappedOnMenu(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuView(), false);
        }

        async void BackHome(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomeView(), false);
            resetUI();
        }

        //Update UI
        void updateUI()
        {

            int yukihyoXp = yukihyo.Xp;

            Device.BeginInvokeOnMainThread(async () => {

                if (yukihyoXp < 1)
                {
                    xpLevel.Text = "XP 0";
                }
                else
                {
                    xpLevel.Text = "XP " + Level.GetLevelFromXp(yukihyoXp).ToString();
                }

            });
        }

        public void Handle_SlideCompleted(object sender, System.EventArgs e)
        {
            ChangeTempDone();
        }

        /*Done Feeding Animation*/
        public void ChangeTempDone()
        {
            tempSlider.IsVisible = false;
            doneAnimation.IsPlaying = true;
            doneAnimation.IsVisible = true;
            buttonToHome.IsVisible = true;

            yukihyoHabitatImage.Source = "happy_habitat_yukihyo";

            yukihyo.giveFood();
        }

        private void resetUI()
        {
            tempSlider.IsVisible = true;
            doneAnimation.IsPlaying = false;
            doneAnimation.IsVisible = false;
            buttonToHome.IsVisible = false;

            yukihyoHabitatImage.Source = "sad_habitat_yukihyo";
        }
    }
}