using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summary.Api
{
    public class RootObject
    {
        public string blog { get; set; }
        public string blogName { get; set; }
        public string body { get; set; }
        public string byline { get; set; }
        public bool commentsEnabled { get; set; }
        public int firstPublishedTs { get; set; }
        public object id { get; set; }
        public string kicker { get; set; }
        public int printPubDate { get; set; }
        public int pubDate { get; set; }
        public List<RelatedAsset> relatedAssets { get; set; }
        public string section { get; set; }
        public string sectionDisplayName { get; set; }
        public string summary { get; set; }
        public string tinyUrl { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public int updatedDate { get; set; }
        public string url { get; set; }
        public string __invalid_name__article_list { get; set; }
        public List<string> authors { get; set; }
        public List<string> keywords { get; set; }
        public string printEdition { get; set; }
        public string printHeadline { get; set; }
        public string printPageNumber { get; set; }
        public string printSection { get; set; }
        public string subsection { get; set; }
        public string tagline { get; set; }
        public bool? showTimestamp { get; set; }

        //public string id { get; set; }
        //public string first_name { get; set; }
        //public string gender { get; set; }
        //public string last_name { get; set; }
        //public string link { get; set; }
        //public string locale { get; set; }
        //public string name { get; set; }
        //public string username { get; set; }
    }
}
