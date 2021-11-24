using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ActivatingForRideDTO
    {
        public int Id { get; set; }
        public System.DateTime ActivatingDate { get; set; }
        public int ActivatingNum { get; set; }
        public System.DateTime ActivatingTime { get; set; }
        public bool Status { get; set; }
        public int ParticipantNum { get; set; }
        public int RideManagerId { get; set; }
        public int RideId { get; set; }
    }
}
