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
    public partial class SafetyView : ContentPage
    {
        private Yukihyo yukihyo = new Yukihyo();

        public SafetyView()
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

        /*Update UI with Level*/
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

        async void poacher1Drop(object sender, DragEventArgs e)
        {
            jailIcon.Source = "jail_icon";
            await poacher1.ScaleTo(1.5, 100, Easing.BounceIn);
            await poacher1.ScaleTo(0.2, 100, Easing.BounceOut);
            await poacher1.FadeTo(0, 100);
        }

        async void poacher2Drop(object sender, DragEventArgs e)
        {
            jailIcon.Source = "jail_icon";
            await poacher2.ScaleTo(1.5, 100, Easing.BounceIn);
            await poacher2.ScaleTo(0.2, 100, Easing.BounceOut);
            await poacher2.FadeTo(0, 100);
        }

        async void poacher3Drop(object sender, DragEventArgs e)
        {
            jailIcon.Source = "jail_icon";
            await poacher3.ScaleTo(1.5, 100, Easing.BounceIn);
            await poacher3.ScaleTo(0.2, 100, Easing.BounceOut);
            await poacher3.FadeTo(0, 100);
        }

        async void poacher4Drop(object sender, DragEventArgs e)
        {
            jailIcon.Source = "jail_icon";
            await poacher4.ScaleTo(1.5, 100, Easing.BounceIn);
            await poacher4.ScaleTo(0.2, 100, Easing.BounceOut);
            await poacher4.FadeTo(0, 100);
        }

        async void poacher5Drop(object sender, DragEventArgs e)
        {
            jailIcon.Source = "jail_icon";
            await poacher5.ScaleTo(1.5, 100, Easing.BounceIn);
            await poacher5.ScaleTo(0.2, 100, Easing.BounceOut);
            await poacher5.FadeTo(0, 100);
        }

        async void poacher6Drop(object sender, DragEventArgs e)
        {
            jailIcon.Source = "jail_icon";
            await poacher6.ScaleTo(1.5, 100, Easing.BounceIn);
            await poacher6.ScaleTo(0.2, 100, Easing.BounceOut);
            await poacher6.FadeTo(0, 100);
            CatchPoacherDone();
        }

        public void OnDropPoacher(object sender, DropEventArgs e)
        {
            jailIcon.Source = "jail_icon";
        }

        /*Poachers Caught Animation*/
        public void CatchPoacherDone()
        {
            doneAnimation.IsPlaying = true;
            doneAnimation.IsVisible = true;
            buttonToHome.IsVisible = true;

            yukihyo.catchPoacher();
        }

        /*Reset UI and bring back poachers*/
        private void resetUI()
        {
            poacher1.ScaleTo(1, 100);
            poacher1.FadeTo(1, 100, Easing.BounceIn);
            poacher2.ScaleTo(1, 100);
            poacher2.FadeTo(1, 100, Easing.BounceIn);
            poacher3.ScaleTo(1, 100);
            poacher3.FadeTo(1, 100, Easing.BounceIn);
            poacher4.ScaleTo(1, 100);
            poacher4.FadeTo(1, 100, Easing.BounceIn);
            poacher5.ScaleTo(1, 100);
            poacher5.FadeTo(1, 100, Easing.BounceIn);
            poacher6.ScaleTo(1, 100);
            poacher6.FadeTo(1, 100, Easing.BounceIn);

            doneAnimation.IsPlaying = false;
            doneAnimation.IsVisible = false;
            buttonToHome.IsVisible = false;
        }
    }
}