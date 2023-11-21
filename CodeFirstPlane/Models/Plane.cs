using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlane.Models
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int EngineCount { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public int SeatRefId { get; set; }
    }
}
