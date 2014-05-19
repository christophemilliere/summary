using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows;

namespace summary.Api
{
    class Apis
    {
        public void Summary(){
            WebClient client = new WebClient();
            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri("http://prohet.net/teaser/summarize.php"));
        }

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                string texte = e.Result;
                MessageBox.Show(texte);
            }
            else
            {
                MessageBox.Show("Impossible de récupérer les données sur internet : " + e.Error);
            }
        }
    }
}
