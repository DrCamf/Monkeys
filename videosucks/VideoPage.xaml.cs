using LibVLCSharp.Shared;
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
    public partial class VideoPage : ContentPage
    {
        LibVLC _libvlc;
        public VideoPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Core.Initialize();
            _libvlc = new LibVLC();

            

            var media = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/Mandrill.mp4", FromType.FromLocation);
            var media2 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/nightmonkeys.mp4", FromType.FromLocation);
            var media3 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/BabyDeBrazzasMonkey.mp4", FromType.FromLocation);
            var media4 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/BrownSpiderMonkey.mp4", FromType.FromLocation);
            var media5 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/Goldenapeslearntoclimb.mp4", FromType.FromLocation);
            var media6 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/MaroonLanguredLeafMonkey.mp4", FromType.FromLocation);
            var media7 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/RedbackedBeardedSaki.mp4", FromType.FromLocation);
            var media8 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/Suntailedmonkey.mp4", FromType.FromLocation);
            var media9 = new Media(_libvlc, "http://elthoro.dk/Monkey2/Videos/Whiteheadedlangur.mp4", FromType.FromLocation);
            myvideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myvideo1.MediaPlayer = new MediaPlayer(media2) { EnableHardwareDecoding = true };
            myvideo2.MediaPlayer = new MediaPlayer(media3) { EnableHardwareDecoding = true };
            myvideo3.MediaPlayer = new MediaPlayer(media4) { EnableHardwareDecoding = true };
            myvideo4.MediaPlayer = new MediaPlayer(media5) { EnableHardwareDecoding = true };
            myvideo5.MediaPlayer = new MediaPlayer(media6) { EnableHardwareDecoding = true };
            myvideo6.MediaPlayer = new MediaPlayer(media7) { EnableHardwareDecoding = true };
            myvideo7.MediaPlayer = new MediaPlayer(media8) { EnableHardwareDecoding = true };
            myvideo8.MediaPlayer = new MediaPlayer(media9) { EnableHardwareDecoding = true };

            myvideo.MediaPlayer.Stop();
            myvideo1.MediaPlayer.Stop();
            myvideo2.MediaPlayer.Stop();
            myvideo3.MediaPlayer.Stop();
            myvideo4.MediaPlayer.Stop();
            myvideo5.MediaPlayer.Stop();
            myvideo6.MediaPlayer.Stop();
            myvideo7.MediaPlayer.Stop();
            myvideo8.MediaPlayer.Stop();

            //var video1_tap = new TapGestureRecognizer();
            //Lvideo1.GestureRecognizers.Add(video1_tap);


            /* video1_tap.Tapped += (s, e) =>
             {
                 myvideo.MediaPlayer.Stop();
                 myvideo1.MediaPlayer.Stop();
                 myvideo2.MediaPlayer.Stop();
                 myvideo3.MediaPlayer.Stop();
                 myvideo4.MediaPlayer.Stop();
                 myvideo5.MediaPlayer.Stop();
                 myvideo6.MediaPlayer.Stop();
                 myvideo7.MediaPlayer.Stop();
                 myvideo8.MediaPlayer.Stop();
             };*/
        }


        private void video2_Clicked(object sender, EventArgs e)
        {
           // myvideo.MediaPlayer.Play();
            myvideo1.MediaPlayer.Stop();
        }
    }
}