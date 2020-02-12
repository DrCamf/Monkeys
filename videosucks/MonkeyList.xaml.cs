using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace videosucks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeyList : ContentPage
    {
        public MonkeyList(string genus)
        {
            InitializeComponent();
           
            NavigationPage.SetHasNavigationBar(this, false);

            List<Monkey> monkeys = new List<Monkey>();

            string resourceName = FindName(genus);

            TribeName.Text = genus;

            ListOMonkey.ItemsSource = FillMonkeyList(monkeys, resourceName);
        }

        public List<Monkey> FillMonkeyList(List<Monkey> monkeys, string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();


            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new System.IO.StreamReader(stream))
                {
                    var serializer = new XmlSerializer(typeof(List<Monkey>));
                    monkeys = (List<Monkey>)serializer.Deserialize(reader);
                }
            }
            return monkeys;
        }

        public string FindName(string name)
        {
            string resourceName;
            switch (name)
            {
                case "Cercopithecini":
                    resourceName = "videosucks.Data.Cercopithecini.xml";
                    break;
                case "Papionini":
                    resourceName = "videosucks.Data.Papionini.xml";
                    break;
                case "Langur":
                    resourceName = "videosucks.Data.Langur.xml";
                    break;
                case "Oddnosed":
                    resourceName = "videosucks.Data.Oddnosed.xml";
                    break;
                case "Colobus":
                    resourceName = "videosucks.Data.Colobus.xml";
                    break;
                case "Callitrichidae":
                    resourceName = "videosucks.Data.Callitrichidae.xml";
                    break;
                case "Aotidae":
                    resourceName = "videosucks.Data.Aotidae.xml";
                    break;
                case "Cebidae":
                    resourceName = "videosucks.Data.Cebidae.xml";
                    break;
                case "Callicebinae":
                    resourceName = "videosucks.Data.Callicebinae.xml";
                    break;
                case "Pitheciidae":
                    resourceName = "videosucks.Data.Pitheciidae.xml";
                    break;
                case "Alouattinae":
                    resourceName = "videosucks.Data.Aloauttinae.xml";
                    break;
                case "Atelinae":
                    resourceName = "videosucks.Data.Atelinae.xml";
                    break;
                default:
                    resourceName = "videosucks.Data.Cercopithecini.xml";
                    break;
            }

            return resourceName;
        }

        public void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Monkey selectedItem = e.SelectedItem as Monkey;
        }

        public async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Monkey tappedItem = e.Item as Monkey;
            await Navigation.PushAsync(new ShowtheMonkey(tappedItem));

        }
    }
}