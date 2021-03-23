using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Timers;
using yukihyo.Objects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yukihyo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class HomeView : ContentPage
    {

        /*Navigation*/
        async void TappedOnMenu(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuView(), false);
        }

        async void TappedOnHabitat(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HabitatView(), false);
        }

        async void TappedOnHunger(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedView(), false);
        }

        async void TappedOnSafety(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SafetyView(), false);
        }

        private Yukihyo yukihyo = new Yukihyo();
        private Yukihyo hunger = new Yukihyo();
        private Yukihyo habitat = new Yukihyo();
        private Yukihyo safety = new Yukihyo();

        private TimeKeeper timeKeeper = new TimeKeeper();
        private TimeKeeperHunger timeKeeperHunger = new TimeKeeperHunger();
        private TimeKeeperHabitat timeKeeperHabitat = new TimeKeeperHabitat();
        private TimeKeeperSafety timeKeeperSafety = new TimeKeeperSafety();

        private static Timer timer;

        /*HomeView*/
        public HomeView()
        {
            InitializeComponent();
            updateUI();
            StartTimer();
            StartHungerTimer();
            StartHabitatTimer();
            StartSafetyTimer();
        }


        /*Update UI Name*/
        void updateUI()
        {

            int yukihyoXp = yukihyo.Xp;

            Device.BeginInvokeOnMainThread(async () =>
            {
                yukihyoImage.Source = yukihyo.CurrentYukihyoState.ToString() + "_yukihyo";

                if (yukihyoXp < 1)
                {
                    xpLevel.Text = "XP 0";
                }
                else
                {
                    xpLevel.Text = "XP " + Level.GetLevelFromXp(yukihyoXp).ToString();
                }

                if (yukihyoNameLabel.Text != yukihyo.YukihyoName)
                {
                    yukihyoNameLabel.Text = yukihyo.YukihyoName;
                }

                if (yukihyo.CurrentYukihyoState == YukihyoState.sad)
                {
                    YukihyoCareFailed();
                }
            });
        }

        /*Update Hunger UI*/
        void updateHungerUI()
        {
            hungerStateIcon.Source = "yukihyo_state_" + hunger.CurrentHungerState.ToString();

            Device.BeginInvokeOnMainThread(async () =>
            {
                if(hunger.CurrentHungerState == HungerState.sad)
                {
                    await hungerStateIcon.FadeTo(1, 700, Easing.BounceIn);
                }
            });
        }

        /*Update Habitat UI*/
        void updateHabitatUI()
        {
            habitatStateIcon.Source = "yukihyo_state_" + habitat.CurrentHabitatState.ToString();

            Device.BeginInvokeOnMainThread(async () =>
            {
                if (habitat.CurrentHabitatState == HabitatState.sad)
                {
                    await habitatStateIcon.FadeTo(1, 700, Easing.BounceIn);
                }
            });
        }

        /*Update Safety UI*/
        void updateSafetyUI()
        {
            safetyStateIcon.Source = "yukihyo_state_" + safety.CurrentSafetyState.ToString();

            Device.BeginInvokeOnMainThread(async () =>
            {
                if (safety.CurrentSafetyState == SafetyState.sad)
                {
                    await safetyStateIcon.FadeTo(1, 700, Easing.BounceIn);
                }
            });
        }

        /*Yukihyo Care Failed*/
        private async void YukihyoCareFailed()
        {
            await DisplayAlert("Care", "Yukihyo failed to live the circumstances", "Start Again");

            yukihyo.Xp = 0;
            yukihyo.CurrentYukihyoState = YukihyoState.happy;
            ResetTimer();
            ResetHungerTimer();
            ResetHabitatTimer();
            ResetSafetyTimer();

            updateUI();
        }

        /*Start General Timer*/
        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateTimedData;
            timer.Start();
        }

        /*Start Hunger Timer*/
        private void StartHungerTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateHungerTimedData;
            timer.Start();
        }

        /*Start Habitat Timer*/
        private void StartHabitatTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateHabitatTimedData;
            timer.Start();
        }

        /*Start Safety Timer*/
        private void StartSafetyTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateSafetyTimedData;
            timer.Start();
        }

        /*Reset General Timer*/
        private void ResetTimer()
        {
            timeKeeper.StartTime = DateTime.Now;

        }

        /*Reset Hunger Timer*/
        private void ResetHungerTimer()
        {
            timeKeeperHunger.StartTime = DateTime.Now;

            StartHungerTimer();
        }

        /*Reset Habitat Timer*/
        private void ResetHabitatTimer()
        {
            timeKeeperHunger.StartTime = DateTime.Now;

            StartHabitatTimer();
        }

        /*Reset Safety Timer*/
        private void ResetSafetyTimer()
        {
            timeKeeperSafety.StartTime = DateTime.Now;

            StartSafetyTimer();
        }

        /*Updated General Timer*/
        private void UpdateTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeElapsed = e.SignalTime - timeKeeper.StartTime;

            YukihyoState newYukihyoState = yukihyo.CurrentYukihyoState;

            if (yukihyo.YukihyoName != yukihyoNameLabel.Text)
            {
                yukihyoNameLabel.Text = yukihyo.YukihyoName.ToString();
            }

            if (timeElapsed.TotalSeconds < 20)
            {
                newYukihyoState = YukihyoState.happy;
            }
            else if (timeElapsed.TotalSeconds < 30)
            {
                newYukihyoState = YukihyoState.neutral;
            }
            else if (timeElapsed.TotalSeconds >= 40)
            {
                newYukihyoState = YukihyoState.sad;
            }

            /* Update Yukihyo state */

            if (newYukihyoState != yukihyo.CurrentYukihyoState)
            {
                yukihyo.CurrentYukihyoState = newYukihyoState;
                updateUI();
            }
        }

        /*Updated Hunger Timer*/
        private void UpdateHungerTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeHungerElapsed = e.SignalTime - timeKeeperHunger.StartTime;

            HungerState newHungerState = hunger.CurrentHungerState;

            if (timeHungerElapsed.TotalSeconds < 20)
            {
                newHungerState = HungerState.happy;
                hungerProgressBar.ProgressTo(1, 700, Easing.SinIn);
            }
            else if (timeHungerElapsed.TotalSeconds < 30)
            {
                newHungerState = HungerState.neutral;
                hungerProgressBar.ProgressTo(0.5, 700, Easing.SinIn);
            }
            else if (timeHungerElapsed.TotalSeconds >= 40)
            {
                newHungerState = HungerState.sad;
                hungerProgressBar.ProgressTo(0.1, 700, Easing.SinIn);
            }

            /* Update Hunger state */

            if (newHungerState != hunger.CurrentHungerState)
            {
                hunger.CurrentHungerState = newHungerState;
                updateHungerUI();
            }
        }

        /*Updated Habitat Timer*/
        private void UpdateHabitatTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeHabitatElapsed = e.SignalTime - timeKeeperHabitat.StartTime;

            HabitatState newHabitatState = habitat.CurrentHabitatState;

            if (timeHabitatElapsed.TotalSeconds < 20)
            {
                newHabitatState = HabitatState.happy;
                habitatProgressBar.ProgressTo(1, 700, Easing.SinIn);
            }
            else if (timeHabitatElapsed.TotalSeconds < 30)
            {
                newHabitatState = HabitatState.neutral;
                habitatProgressBar.ProgressTo(0.5, 700, Easing.SinIn);
            }
            else if (timeHabitatElapsed.TotalSeconds >= 40)
            {
                newHabitatState = HabitatState.sad;
                habitatProgressBar.ProgressTo(0.1, 700, Easing.SinIn);
            }

            /* Update Habitat state */

            if (newHabitatState != habitat.CurrentHabitatState)
            {
                habitat.CurrentHabitatState = newHabitatState;
                updateHabitatUI();
            }
        }

        /*Updated Safety Timer*/
        private void UpdateSafetyTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeSafetyElapsed = e.SignalTime - timeKeeperSafety.StartTime;

            SafetyState newSafetyState = safety.CurrentSafetyState;

            if (timeSafetyElapsed.TotalSeconds < 20)
            {
                newSafetyState = SafetyState.happy;
                safetyProgressBar.ProgressTo(1, 700, Easing.SinIn);
            }
            else if (timeSafetyElapsed.TotalSeconds < 30)
            {
                newSafetyState = SafetyState.neutral;
                safetyProgressBar.ProgressTo(0.5, 700, Easing.SinIn);
            }
            else if (timeSafetyElapsed.TotalSeconds >= 40)
            {
                newSafetyState = SafetyState.sad;
                safetyProgressBar.ProgressTo(0.1, 700, Easing.SinIn);
            }

            /* Update Safety state */

            if (newSafetyState != safety.CurrentSafetyState)
            {
                safety.CurrentSafetyState = newSafetyState;
                updateSafetyUI();
            }
        }
    }
}