using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextcars.domain
{
    public class CarDiamention
    {
        public int? dimId { get; set; }
        public int carId { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int WheelBase { get; set; }
        public int GroundClerance { get; set; }
        public int? FrontTrack { get; set; }
        public int? RearTrack { get; set; }
        public int? FuelTank { get; set; }

    }
}
