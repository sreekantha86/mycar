using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextcars.domain
{
    public class Manufacture
    {
        public int mfId { get; set; }
        public string mfName { get; set; }
        public string mfShortName { get; set; }
        public int ctId { get; set; }
        public int mfStartYear { get; set; }
        public string mfDescription { get; set; }
        public string mfLink { get; set; }
        public string mfLogo { get; set; }
        public bool isEnabled { get; set; }
    }
}
