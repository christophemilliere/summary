using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Diagnostics;

namespace summary.Api
{
    class Apis
    {

        private string blog;

        public string Blog
        {
            get { return blog; }
            set { blog = value; }
        }
        private string blogName;

        public string BlogName
        {
            get { return blogName; }
            set { blogName = value; }
        }
        
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

                //MessageBox.Show((string)JsonConvert.DeserializeObject(texte));
                List<Object> products = JsonConvert.DeserializeObject<List<Object>>(texte);
                
                //Console.WriteLine(JsonConvert.SerializeObject(texte));
     
            }
            else
            {
                MessageBox.Show("Impossible de récupérer les données sur internet : " + e.Error);
            }
        }
    }
}
