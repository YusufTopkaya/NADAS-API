using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.Entities.Concrete
{
    public class NotificationItem
    {
        public string? to { get; set; }
        public Notification? notification { get; set; }
    }
}
