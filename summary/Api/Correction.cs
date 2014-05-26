using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summary.Api
{
    public class Correction
    {
        public string correction_date { get; set; }
        public string correction_text { get; set; }
        public bool is_fixed_in_text { get; set; }
        public string type { get; set; }
    }
}
