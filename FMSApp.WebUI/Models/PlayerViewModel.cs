using FMSApp.DAL.Models;

namespace FMSApp.WebUI.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Number { get; set; }
        public string FullName { get; set; }
    }
}
