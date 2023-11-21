using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlane.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string SeatType { get; set; }
        public int SeatNumber { get; set; }
        public Plane Plane { get; set; }
        public int PlaneRefId { get; set; }
    }
}
