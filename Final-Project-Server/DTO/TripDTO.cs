using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TripDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public System.DateTime TripDate { get; set; }
        public int MembersNum { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
    }
}
