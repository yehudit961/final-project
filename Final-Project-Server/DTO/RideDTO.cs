using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RideDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int SeatsNum { get; set; }
        public int ActivatingDurationMinutes { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int NotificationTimeMinutes { get; set; }
        public int ActivatingsNum { get; set; }
        public int RidesWaitingTime { get; set; }
        public string Price { get; set; }
    }
}
