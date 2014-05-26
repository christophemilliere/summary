using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using summary.Resources;
using summary.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace summary
{
    public partial class MainPage : PhoneApplicationPage
    {
        private List<RootObject> roots;
        public List<RootObject> Roots
        {
            get { return roots; }
            set { roots = value; }
        }
        // Constructeur
        public MainPage()
        {
            InitializeComponent();
            WebClient client = new WebClient();
            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri("http://prohet.net/teaser/summarize.php"));
        }

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    roots = JsonConvert.DeserializeObject<List<RootObject>>(e.Result);
                    this.DataContext = this;
                    foreach (RootObject root in roots)
                    {
                        if (root.assets == null)
                        {
                            Assets asset = new Assets() { url = "Assets/flou.jpg", height = 480, width = 800 };
                            root.assets = asset;
                        }
                    }
                }
                catch (Newtonsoft.Json.JsonSerializationException jse)
                {
                    MessageBox.Show("erreur json : " + jse.Message + "----------------" + jse.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Impossible de récupérer les données sur internet : " + e.Error);
            }
        }

        private void Item_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (sender is ListBox)
            {
                object obj = (sender as ListBox).SelectedItem;
                PhoneApplicationService.Current.State["Item"] = (RootObject)obj;
            }
            NavigationService.Navigate(new Uri("/DetailPage.xaml", UriKind.Relative));
        }
    }
}