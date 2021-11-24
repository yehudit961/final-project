using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GradingDTO
    {
        public int Id { get; set; }
        public int RideId { get; set; }
        public string RecommendText { get; set; }
        public Nullable<int> UserId { get; set; }
        public int Grading1 { get; set; }
        public bool Status { get; set; }

    }
}
