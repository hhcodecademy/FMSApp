using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.DAL.Models
{
    public class Game:BaseEntity
    {
        public int WeekNumber { get; set; }
        public string StadiumName { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int GuestTeamId { get; set; }
        public Team GuestTeam { get; set; }
    }
}
