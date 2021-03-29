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
    public partial class FeedView : ContentPage
    {
        private Yukihyo yukihyo = new Yukihyo();

        public FeedView()
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

        /*Hide Marmots on Tap*/
        async private void marmot1Tapped(object sender, EventArgs args)
        {
            await marmot1.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot1.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot1.FadeTo(0, 100);
        }

        async private void marmot2Tapped(object sender, EventArgs args)
        {
            await marmot2.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot2.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot2.FadeTo(0, 100);
        }

        async private void marmot3Tapped(object sender, EventArgs args)
        {
            await marmot3.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot3.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot3.FadeTo(0, 100);
        }

        async private void marmot4Tapped(object sender, EventArgs args)
        {
            await marmot4.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot4.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot4.FadeTo(0, 100);
        }

        async private void marmot5Tapped(object sender, EventArgs args)
        {
            await marmot5.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot5.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot5.FadeTo(0, 100);
        }

        async private void marmot6Tapped(object sender, EventArgs args)
        {
            await marmot6.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot6.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot6.FadeTo(0, 100);
        }

        async private void marmot7Tapped(object sender, EventArgs args)
        {
            await marmot7.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot7.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot7.FadeTo(0, 100);
        }

        async private void marmot8Tapped(object sender, EventArgs args)
        {
            await marmot8.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot8.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot8.FadeTo(0, 100);
        }

        async private void marmot9Tapped(object sender, EventArgs args)
        {
            await marmot9.ScaleTo(1.5, 100, Easing.BounceIn);
            await marmot9.ScaleTo(0.2, 100, Easing.BounceOut);
            await marmot9.FadeTo(0, 100);
            FeedingDone();
        }

        /*Done Feeding Animation*/
        public void FeedingDone()
        {
            doneAnimation.IsPlaying = true;
            doneAnimation.IsVisible = true;
            buttonToHome.IsVisible = true;
            yukihyo.giveFood();
        }

        /*Reset UI and bring back marmots*/
        private void resetUI()
        {
            marmot1.ScaleTo(1, 100);
            marmot1.FadeTo(1, 100, Easing.BounceIn);
            marmot2.ScaleTo(1, 100);
            marmot2.FadeTo(1, 100, Easing.BounceIn);
            marmot3.ScaleTo(1, 100);
            marmot3.FadeTo(1, 100, Easing.BounceIn);
            marmot4.ScaleTo(1, 100);
            marmot4.FadeTo(1, 100, Easing.BounceIn);
            marmot5.ScaleTo(1, 100);
            marmot5.FadeTo(1, 100, Easing.BounceIn);
            marmot6.ScaleTo(1, 100);
            marmot6.FadeTo(1, 100, Easing.BounceIn);
            marmot7.ScaleTo(1, 100);
            marmot7.FadeTo(1, 100, Easing.BounceIn);
            marmot8.ScaleTo(1, 100);
            marmot8.FadeTo(1, 100, Easing.BounceIn);
            marmot9.ScaleTo(1, 100);
            marmot9.FadeTo(1, 100, Easing.BounceIn);
            doneAnimation.IsPlaying = false;
            doneAnimation.IsVisible = false;
            buttonToHome.IsVisible = false;
        }
    }
}