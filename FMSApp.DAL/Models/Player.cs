using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.DAL.Models
{
    public class Player:BaseEntity
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int Number { get; set; }
        public string FullName { get; set; }
    }
}
