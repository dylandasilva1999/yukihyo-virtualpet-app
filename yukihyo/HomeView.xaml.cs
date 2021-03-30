using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using yukihyo.Objects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yukihyo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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
                    TapText.IsVisible = false;
                }

                if (yukihyoNameLabel.Text != yukihyo.YukihyoName)
                {
                    yukihyoNameLabel.Text = yukihyo.YukihyoName;
                }

                if (yukihyo.CurrentYukihyoState == YukihyoState.sad)
                {
                    YukihyoCareFailed();
                }

                //hungerProgress(Convert.ToDouble((yukihyo.HungerXp)) / 100);
                //habitatProgress(Convert.ToDouble((yukihyo.HabitatXp)) / 100);
                //safetyProgress(Convert.ToDouble((yukihyo.SafetyXp)) / 100);
            });
        }

        ///*Hunger ProgressBar*/
        //async private void hungerProgress(double i)
        //{
        //    await hungerProgressBar.ProgressTo(i, 100, Easing.Linear);
        //}

        ///*Habitat ProgressBar*/
        //async private void habitatProgress(double i)
        //{
        //    await habitatProgressBar.ProgressTo(i, 100, Easing.Linear);
        //}

        ///*Safety ProgressBar*/
        //async private void safetyProgress(double i)
        //{
        //    await safetyProgressBar.ProgressTo(i, 100, Easing.Linear);
        //}

        async void yukihyoTapped(System.Object sender, System.EventArgs e)
        {
            ResetHungerTimer();
            ResetHabitatTimer();
            ResetSafetyTimer();
            ResetTimer();

            updateHungerUI();
            updateHabitatUI();
            updateSafetyUI();
            updateUI();

            yukihyo.Cease();
            yukihyo.Heat();
            yukihyo.Unsafe();

            TapText.IsVisible = false;
        }

        /*Update Hunger UI*/
        void updateHungerUI()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                hungerStateIcon.Source = "yukihyo_state_" + hunger.CurrentHungerState.ToString();

                if (hunger.CurrentHungerState == HungerState.sad)
                {
                    await hungerStateIcon.FadeTo(1, 50);
                    TapText.IsVisible = false;
                    //GiveFood();
                }
            });
        }

        /*Show Feed Interaction*/
        async private void GiveFood()
        {
            var feedView = new FeedView();

            feedView.Disappearing += (sender2, e2) => {
                updateHungerUI();
                StartHungerTimer();
            };

            await Navigation.PushModalAsync(feedView);

            await DisplayAlert("Hungry", "Your Yukihyo is hungry", "Feed");
        }

        /*Update Habitat UI*/
        void updateHabitatUI()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                habitatStateIcon.Source = "yukihyo_state_" + habitat.CurrentHabitatState.ToString();

                if (habitat.CurrentHabitatState == HabitatState.sad)
                {
                    await habitatStateIcon.FadeTo(1, 50);
                    TapText.IsVisible = false;
                    //ChangeTemp();
                }
            });
        }

        /*Show Habitat Interaction*/
        async private void ChangeTemp()
        {
            var habitatView = new HabitatView();

            habitatView.Disappearing += (sender2, e2) => {
                updateHabitatUI();
                StartHabitatTimer();
            };

            await Navigation.PushModalAsync(habitatView);

            await DisplayAlert("Hot", "Your Yukihyo is getting hot", "Change Temperature");
        }

        /*Update Safety UI*/
        void updateSafetyUI()
        {    
            Device.BeginInvokeOnMainThread(async () =>
            {
                safetyStateIcon.Source = "yukihyo_state_" + safety.CurrentSafetyState.ToString();

                if (safety.CurrentSafetyState == SafetyState.sad)
                {
                    await safetyStateIcon.FadeTo(1, 50);
                    TapText.IsVisible = false;
                    //CatchPoachers();
                }
            });
        }

        /*Show Safety Interaction*/
        async private void CatchPoachers()
        {
            var safetyView = new SafetyView();

            safetyView.Disappearing += (sender2, e2) => {
                updateSafetyUI();
                StartSafetyTimer();
            };

            await Navigation.PushModalAsync(safetyView);

            await DisplayAlert("Unsafe", "Your Yukihyo is not safe", "Catch Poachers");
        }

        /*Yukihyo Care Failed*/
        private async void YukihyoCareFailed()
        {
            try
            {
                yukihyo.Xp = 0;
                yukihyo.CurrentYukihyoState = YukihyoState.happy;
                ResetTimer();
                ResetHabitatTimer();
                ResetHungerTimer();
                ResetSafetyTimer();
                updateUI();

                Device.BeginInvokeOnMainThread(async () =>
                {
                    var yukihyoState = yukihyo.CurrentYukihyoState;

                    if (yukihyoState == YukihyoState.sad)
                    {
                        await DisplayAlert("died", "your yukihyo has not made it", "new yukihyo?", "exit");
                        yukihyoImage.Source = yukihyo.CurrentYukihyoState.ToString() + "_yukihyo";
                        await Navigation.PushModalAsync(new EnterNameView(), false);
                    } 
                });

            } catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
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

            StartTimer();
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
            timeKeeperHabitat.StartTime = DateTime.Now;

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

            if (timeElapsed.TotalSeconds < 30)
            {
                newYukihyoState = YukihyoState.happy;
                
            }
            else if (timeElapsed.TotalSeconds < 50)
            {
                newYukihyoState = YukihyoState.neutral;
            }
            else if (timeElapsed.TotalSeconds >= 140)
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

            if (timeHungerElapsed.TotalSeconds < 30)
            {
                newHungerState = HungerState.happy;
                hungerProgressBar.ProgressTo(1, 500, Easing.Linear);
            }
            else if (timeHungerElapsed.TotalSeconds < 50)
            {
                newHungerState = HungerState.neutral;
                hungerProgressBar.ProgressTo(0.5, 500, Easing.Linear);
            }
            else if (timeHungerElapsed.TotalSeconds >= 70)
            {
                newHungerState = HungerState.sad;
                hungerProgressBar.ProgressTo(0.1, 500, Easing.Linear);
                GiveFood();
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

            if (timeHabitatElapsed.TotalSeconds < 40)
            {
                newHabitatState = HabitatState.happy;
                habitatProgressBar.ProgressTo(1, 500, Easing.Linear);
            }
            else if (timeHabitatElapsed.TotalSeconds < 60)
            {
                newHabitatState = HabitatState.neutral;
                habitatProgressBar.ProgressTo(0.5, 500, Easing.Linear);
            }
            else if (timeHabitatElapsed.TotalSeconds >= 80)
            {
                newHabitatState = HabitatState.sad;
                habitatProgressBar.ProgressTo(0.1, 500, Easing.Linear);
                ChangeTemp();
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
                safetyProgressBar.ProgressTo(1, 500, Easing.Linear);
            }
            else if (timeSafetyElapsed.TotalSeconds < 40)
            {
                newSafetyState = SafetyState.neutral;
                safetyProgressBar.ProgressTo(0.5, 500, Easing.Linear);
            }
            else if (timeSafetyElapsed.TotalSeconds >= 60)
            {
                newSafetyState = SafetyState.sad;
                safetyProgressBar.ProgressTo(0.1, 500, Easing.Linear);
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