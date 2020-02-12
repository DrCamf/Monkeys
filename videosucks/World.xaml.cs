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
    public partial class World : ContentPage
    {
        public Label monkeyLabel;
        public Button monkeyButton;
        public World(string place)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var mWorld = Enumerable.Range(1, 5).Select(i => new MonkeyWorld()).ToList();
            

            if (place == "OldWorld")
            {
                worldName.Text = "Monkeys from the Old world";
                mWorld = MakeOldWorld(mWorld);
            }
            else
            {
                worldName.Text = "Monkeys from the New world";
                MakeNewWorld();
            }
            WorldOMonkey.ItemsSource = mWorld;
        }

        private void SubRace_Clicked(object sender, EventArgs e)
        {
            string bname = ((Button)sender).Text;

            Navigation.PushAsync(new MonkeyList(bname));

        }

        public void MakeNewWorld()
        {
            List<string> newMonkeys = new List<string> { "Callitrichidae", "Cebidae", "Aotidae", "Callicebinae", "Pitheciidae", "Alouattinae", "Atelinae" };
            List<string> typeInfo = new List<string> {
            "The Callitrichidae (also called Arctopitheci or Hapalidae) are a family of New World monkeys, including marmosets, tamarins and lion tamarins. At times, this group of animals has been regarded as a subfamily, called Callitrichinae, of the family Cebidae.",
            "The Cebidae are one of the five families of New World monkeys now recognised. Extant members are the capuchin and squirrel monkeys.[2] These species are found throughout tropical and subtropical South and Central America.",
            "The night monkeys, also known as the owl monkeys or douroucoulis, are the members of the genus Aotus of New World monkeys (monotypic in family Aotidae). The only nocturnal monkeys, they are native to Panama and much of tropical South America. ",
            "The titis, or titi monkeys, are the New World monkeys of the subfamily Callicebinae, which contains three extant genera, Cheracebus, Callicebus, and Plecturocebus.[1][2] This subfamily also contains the extinct genera Xenothrix, Antillothrix, Paralouatta, Carlocebus, Lagonimico, and possibly also Tremacebus.",
            "The Pitheciidae are one of the five families of New World monkeys now recognised. Formerly, they were included in the family Atelidae. The family includes the titis, saki monkeys and uakaris. Most species are native to the Amazon region of Brazil, with some being found from Colombia in the north to Bolivia in the south.",
            "Howler monkeys (genus Alouatta monotypic in subfamily Alouattinae) are among the largest of the New World monkeys. They are famous for their loud howls, which can travel three miles through dense rain forest. These monkeys are native to South and Central American forests.",
            "The Atelinae are a subfamily of New World monkeys in the family Atelidae, and includes the various spider and woolly monkeys.[2] The primary distinguishing feature of the atelines is their long prehensile tails, which can support their entire body weight."
            };
            List<string> goToInfo = new List<string> { "Go to the Cercopithecinae", "Go to the Papionini", "Go to the Langur group", "Go to the Odd-nosed group", "Go to the Colobuses group" };

            


            for (int i = 0; i <= 6; i++)
            {
                
            }
        }

        public List<MonkeyWorld> MakeOldWorld(List<MonkeyWorld> mWorld)
        {
            List<string> oldMonkeys = new List<string> { "Cercopithecini", "Papionini", "Langur", "Oddnosed", "Colobus" };
            List<string> typeInfo = new List<string> {
            "The Cercopithecinae are a subfamily of the Old World monkeys, which comprises roughly 71 species, including the baboons, the macaques, and the vervet monkeys. Most cercopithecine monkeys are limited to sub-Saharan Africa, although the macaques range from the far eastern parts of Asia through northern Africa, as well as on Gibraltar.",
            "The Papionini are a tribe of Old World monkeys that includes several large monkey species, which include the macaques of North Africa and Asia, as well as the baboons, geladas, mangabeys, kipunji, drills, and mandrills, which are essentially from sub-Saharan Africa (although some baboons also occur in southern Arabia).[1] It is typically divided into two subtribes: Macacina for the genus Macaca and its extinct relatives and the Papionina for all other genera.",
            "Langur, general name given to numerous species of Asian monkeys belonging to the subfamily Colobinae. The term is often restricted to nearly two dozen species of leaf monkeys but is also applied to various other members of the subfamily.",
            "Odd-nosed monkeys represent one of the two major groups of Asian colobines.",
            "Colobuses (or colobi) are Old World monkeys of the genus Colobus, native to Africa. They are closely related to the red colobus monkeys of genus Piliocolobus."
            };
            List<string> goToInfo = new List<string> { "Go to the Cercopithecinae", "Go to the Papionini", "Go to the Langur group", "Go to the Odd-nosed group", "Go to the Colobuses group" };
            List<string> imageUrl = new List<string> { "Allensswampmonkey.jpg", "Angolantalapoin.jpg", "BaleMountainsvervet.jpg", "Campbellsmonamonkey.jpg", "DeBrazzasmonkey.jpg" };


            //Image Cercopithecini, Papionini, Langur, Oddnosed, Colobus;

            for (int i = 0; i <= 4; i++)
            {

                mWorld[i].Name = oldMonkeys[i];
                mWorld[i].Info = typeInfo[i];
                mWorld[i].GoTo = goToInfo[i];
                mWorld[i].ImageUrl = imageUrl[i];

                /*
                monkeyLabel = new Label();
                monkeyLabel.Text = oldMonkeys[i];
                monkeyLabel.StyleClass = new List<string>() { "uppmonkey" };
                grid.Children.Add(monkeyLabel);
                monkeyLabel = new Label();
                monkeyLabel.Text = typeInfo[i];
                monkeyLabel.StyleClass = new List<string>() { "infomonkey" };
                grid.Children.Add(monkeyLabel);
               
               
                grid.Children.Add(new Label
                {
                    Text = goToInfo[i],
                    StyleClass = new List<string>() { "infomonkey" },
                });*/
                /*
                switch (i)
                {
                    case 0:
                        Cercopithecini = new Image() { Source = "Allensswampmonkey.jpg", HeightRequest = 100, WidthRequest = 100 };
                        Cercopithecini.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => { Navigation.PushAsync(new MonkeyList("Callitrichidae")); }), NumberOfTapsRequired = 1 });
                        grid.Children.Add(Cercopithecini);
                        break;
                    case 1:
                        Papionini = new Image() { Source = "Bonnetmacaque.jpg", HeightRequest = 100, WidthRequest = 100 };
                        Papionini.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => { Navigation.PushAsync(new MonkeyList("Papionini")); }), NumberOfTapsRequired = 1 });
                        grid.Children.Add(Papionini);
                        break;
                    case 2:
                        Langur = new Image() { Source = "Maroonleafmonkey.jpg", HeightRequest = 100, WidthRequest = 100 };
                        Langur.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => { Navigation.PushAsync(new MonkeyList("Langur")); }), NumberOfTapsRequired = 1 });
                        grid.Children.Add(Langur);
                        break;
                    case 3:
                        Oddnosed = new Image() { Source = "Proboscismonkey.jpg", HeightRequest = 100, WidthRequest = 100 };
                        Oddnosed.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => { Navigation.PushAsync(new MonkeyList("Oddnosed")); }), NumberOfTapsRequired = 1 });
                        grid.Children.Add(Oddnosed);
                        break;
                    case 4:
                        Colobus = new Image() { Source = "TanaRiverredcolobus.jpg", HeightRequest = 100, WidthRequest = 100 };
                        Colobus.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(() => { Navigation.PushAsync(new MonkeyList("Colobus")); }), NumberOfTapsRequired = 1 });
                        grid.Children.Add(Colobus);
                        break;

                }*/



            }

            return mWorld;
        }
    }
}