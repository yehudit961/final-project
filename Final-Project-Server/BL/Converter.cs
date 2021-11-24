using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class Converter/* : IEntity<UserDTO, UserDal>*/
    {
        //public UserDTO ConvertToDTO(UserDal entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public UserDal ConvertToEntity(UserDTO dto)
        //{
        //    throw new NotImplementedException();
        //}
        public static UserDTO ConvertToDTO(User entity)
        {
            UserDTO user = new UserDTO()
            {
                Id = entity.Id,
                Age = entity.Age,
                Password = entity.Password,
                UserType = entity.UserType
            };
            return user;
        }

        public static User ConvertToEntity(UserDTO dto)
        {
            User user = new User()
            {
                Id = dto.Id,
                Age = dto.Age,
                Password = dto.Password,
                UserType = dto.UserType
            };
            return user;
        }

    }
}
