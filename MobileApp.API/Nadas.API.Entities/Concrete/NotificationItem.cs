using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nadas.API.Entities.Concrete
{
    public class NotificationItem
    {
        public string? To { get; set; }
        public Notification? Notification { get; set; }
    }
}
