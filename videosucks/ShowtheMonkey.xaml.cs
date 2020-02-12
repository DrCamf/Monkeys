using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace videosucks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowtheMonkey : ContentPage
    {
        public ShowtheMonkey(Monkey monkey)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            var value = monkey.Info;
            lblName.Text = "Name: " + monkey.Name;
            imgMonkey.Source = monkey.ImageUrl;
            fromMonkey.Text = "Lives in: " + monkey.Location;
            infoMonkey.Text = value.Replace("\\n", Environment.NewLine);
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartPage());
        }
    }
}