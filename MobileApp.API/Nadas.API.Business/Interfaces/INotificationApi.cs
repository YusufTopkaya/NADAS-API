using Nadas.API.DTO.DTOs.NotificationDtos;
using Nadas.API.Entities.Concrete;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.Business.Interfaces
{
    [Headers("Content-Type: application/json")]
    public interface INotificationApi
    {
        [Post("/fcm/send")]
        Task NotifyUser([Body] NotificationItem notificationItem, [Header("Authorization")] string authorization);
    }
}
