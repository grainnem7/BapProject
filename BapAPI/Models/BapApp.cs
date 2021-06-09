#nullable disable

namespace BapProject.Models
{
    public partial class BapApp
    {
        public long AppId { get; set; }
        public long? Rating { get; set; }
        public string Name { get; set; }
        public long? NoofpeopleRated { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string Price { get; set; }
    }
}
