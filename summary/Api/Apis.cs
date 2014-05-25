using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows;
using Newtonsoft.Json;
using Microsoft.Phone.Shell;

namespace summary.Api
{
    class Apis
    {
        public void Summary(){
            WebClient client = new WebClient();
            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri("http://graph.facebook.com/florent.farges.9"));
        }

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    var root = JsonConvert.DeserializeObject<RootObject>(e.Result);
                    PhoneApplicationService.Current.State["root"] = root;
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
    }
}
