using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextcars.domain
{
    public class CarVideos
    {
        public int? vidId { get; set; }
        public int CrId { get; set; }
        public string vidURL { get; set; }
        public string vidCourtsy { get; set; }
        public string vidDescription { get; set; }
        public int vidTypeId { get; set; }
        public DateTime createDate { get; set; }
    }
}
