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
    public partial class SoundPage : ContentPage
    {
        public Button soundButton;
        public SoundPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasNavigationBar(this, false);



            var RhesusmacaqueS_tap = new TapGestureRecognizer();
            var PatasMonkeyS_tap = new TapGestureRecognizer();
            var GuatemalanblackhowlerS_tap = new TapGestureRecognizer();
            var BlacksquirrelmonkeyS_tap = new TapGestureRecognizer();



            RhesusmacaqueS.GestureRecognizers.Add(RhesusmacaqueS_tap);
            PatasMonkeyS.GestureRecognizers.Add(PatasMonkeyS_tap);
            GuatemalanblackhowlerS.GestureRecognizers.Add(GuatemalanblackhowlerS_tap);
            BlacksquirrelmonkeyS.GestureRecognizers.Add(BlacksquirrelmonkeyS_tap);

            RhesusmacaqueS_tap.Tapped += (s, e) =>
            {
                playSound("rmonkeycolobus.mp3");
            };
            PatasMonkeyS_tap.Tapped += (s, e) =>
            {
                playSound("monkeypatas.mp3");
            };
            GuatemalanblackhowlerS_tap.Tapped += (s, e) =>
            {
                playSound("Guatemalanblackhowler.mp3");
            };
            BlacksquirrelmonkeyS_tap.Tapped += (s, e) =>
            {
                playSound("SQMonkey.mp3");
            };
        }

       

        public void playSound(string name)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(name);
            player.Play();
        }

        public async void back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}