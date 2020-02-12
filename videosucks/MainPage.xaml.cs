using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using static System.Net.WebRequestMethods;

namespace videosucks
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            var monkey_tap = new TapGestureRecognizer();
            monkey_tap.Tapped += (s, e) =>
            {
                if (((Label)s).Text.Contains("continue"))
                {
                    Navigation.PushAsync(new StartPage());
                }
                else if (((Label)s).Text.Contains("stinking"))
                {

                }


            };
            StartContinue.GestureRecognizers.Add(monkey_tap);


        }

        private void goVideoPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VideoPage());
        }
    }
}
