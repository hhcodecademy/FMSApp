using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.DAL.Models
{
    public class TeamDetail:BaseEntity            
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int WinCount { get; set; }
        public int LostCount { get; set; }
        public int DrawCount { get; set; }
        public int Point { get; set;}
    }
}
