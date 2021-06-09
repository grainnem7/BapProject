using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BapProject.ViewModels
{
    public class AppViewModel
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
