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

        async void TappedOnMenu(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuView(), false);
        }
    }
}