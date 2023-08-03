using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Data.Entities
{
    public class UserScore
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string? timetaken  { get; set; }
        public int moves { get; set; }

        public string ?puzzleImage { get; set; }

        public string? playingDate { get; set; }
    }
}
