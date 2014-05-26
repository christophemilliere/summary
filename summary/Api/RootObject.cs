using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace summary.Api
{
    public class RootObject
    {
        public string sectionDisplayName { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string article_list { get; set; }

        public void getImage()
        {
        }
    }
}
