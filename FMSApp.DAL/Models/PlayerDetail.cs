using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.DAL.Models
{
    public class PlayerDetail:BaseEntity
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int GoalCount { get; set; }
    }
}
