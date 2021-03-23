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
    public partial class AttentionView : ContentPage
    {

        public AttentionView()
        {
            InitializeComponent();
        }

        async void TappedOnBack(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomeView(), false);
        }

        async void GiveLove(System.Object sender, System.EventArgs e)
        {
            animationView.IsPlaying = true;

            Image image = sender as Image;
            string source = image.Source as FileImageSource;  //Getting the name of source as string
            if (String.Equals(source, "sad_yukihyo.png"))
            {
                image.Source = "sad_yukihyo.png";
            }
            else
            {
                image.Source = "happy_yukihyo.png";
                await image.FadeTo(1, 50, Easing.CubicIn);
            }

        }
    }
}