using Nadas.API.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.DTO.DTOs.NotificationDtos
{
    public class NotificationCreateDto
    {
        public User Sender { get; set; }
        public User Recipient { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

    }
}
