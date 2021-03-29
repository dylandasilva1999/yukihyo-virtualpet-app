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
    public partial class EnterNameView : ContentPage
    {
        /*New Yukihyo*/
        private Yukihyo yukihyo = new Yukihyo();

        public EnterNameView()
        {
            InitializeComponent();
        }

        /* Navigation */
        async void Start(System.Object sender, System.EventArgs e)
        {
            yukihyo.YukihyoName = yukihyoNameInput.Text;
            await Navigation.PushModalAsync(new HomeView(), false);
        }
    }
}