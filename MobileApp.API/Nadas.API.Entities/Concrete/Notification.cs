using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nadas.API.Entities.Concrete
{
    public class Notification
    {
        public string Body { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
    }
}
