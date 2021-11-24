using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDal
    {
        public static IEnumerable<User> GetUsers()
        {
            using (AmusementParkEntities5 ctx = new AmusementParkEntities5())
            {
                return ctx.Users.ToList();
            }
        }

        public static User GetUser(int id)
        {
            using (AmusementParkEntities5 ctx = new AmusementParkEntities5())
            {
                return ctx.Users.Single(u => u.Id == id);
            }
        }
    }
}
