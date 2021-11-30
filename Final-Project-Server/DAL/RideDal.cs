using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RideDal
    {
        public static Ride GetRide(int id)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Rides.Single(ride => ride.Id == id);
            }
        }

        public static IEnumerable<Ride> GetRides()
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Rides.ToList();
            }
        }

        public static void AddRide(Ride ride)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                ctx.Rides.Add(ride);
                ctx.SaveChanges();
            }
        }

        public static void UpdateRide(Ride ride)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                Ride updatedRide = GetRide(ride.Id);
                updatedRide.Image = ride.Image;
                updatedRide.MaxAge = ride.MaxAge;
                updatedRide.MinAge = ride.MinAge;
                updatedRide.Name = ride.Name;
                updatedRide.NotificationTimeMinutes = ride.NotificationTimeMinutes;
                updatedRide.Price = ride.Price;
                updatedRide.RidesWaitingTime = ride.RidesWaitingTime;
                updatedRide.SeatsNum = ride.SeatsNum;
                ctx.SaveChanges();
            }
        }
    }
}
