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
    public partial class RenameView : ContentPage
    {
        private Yukihyo yukihyo = new Yukihyo();

        public RenameView()
        {
            InitializeComponent();
        }

        async void Rename(System.Object sender, System.EventArgs e)
        {
            yukihyo.YukihyoName = yukihyoNameInput.Text;
            await Navigation.PushModalAsync(new HomeView(), false);
        }
    }
}