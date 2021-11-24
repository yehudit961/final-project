using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CreditDetailDTO
    {
        public int UserId { get; set; }
        public string CreditNumber { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string SafetyDigit { get; set; }

    }
}
