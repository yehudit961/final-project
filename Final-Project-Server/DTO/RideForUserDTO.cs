using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RideForUserDTO
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public int ActivatingRideId { get; set; }

    }
}
