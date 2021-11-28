using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
   public class UserBL
    {
        public static IEnumerable<UserDTO> GetUsers()
        {
            var list = UserDal.GetUsers().ToList();

            foreach (var item in list)
            {
                yield return Conversions.Map(item);

            }
            
        }

        public static UserDTO GetUser(int id)
        {
            //return Converter.ConvertToDTO( UserDal.GetUser(id));
            return Conversions.Map(UserDal.GetUser(id));
        }

        public static void AddUser(UserDTO user)
        {
            UserDal.AddUser(Conversions.Map(user));
        }

        public static UserDTO GetRegisteredUser(string email, string password)
        {
            return GetUsers().FirstOrDefault(user => user.Email == email && user.Password == password);
        }


    }
}
