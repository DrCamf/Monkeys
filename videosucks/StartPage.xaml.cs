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
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            var image_tap = new TapGestureRecognizer();
            var image1_tap = new TapGestureRecognizer();
            var sounds_tap = new TapGestureRecognizer();
            var videos_tap = new TapGestureRecognizer();

            oldworld.GestureRecognizers.Add(image_tap);
            newworld.GestureRecognizers.Add(image1_tap);
            Sounds.GestureRecognizers.Add(sounds_tap);
            Videos.GestureRecognizers.Add(videos_tap);

            image_tap.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new World("OldWorld"));
            };
            image1_tap.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new World("NewWorld"));
            };
            sounds_tap.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new SoundPage());
            };
            videos_tap.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new VideoPage());
            };
        }

       
    }
}