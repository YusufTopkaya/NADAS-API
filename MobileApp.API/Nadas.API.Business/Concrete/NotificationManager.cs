using Microsoft.Extensions.Configuration;
using Nadas.API.Business.Interfaces;
using Nadas.API.DTO.DTOs.NotificationDtos;
using Nadas.API.Entities.Concrete;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.Business.Concrete
{
    public class NotificationManager :INotificationService
    {
        private readonly IFirestoreService _firestoreService;
        private readonly string _fcm;
        public NotificationManager(IFirestoreService firestoreService,IConfiguration configuration)
        {
            _firestoreService = firestoreService;
            _fcm = configuration.GetSection("fcmPrivateKey").Value;
        }

        public void NotifyUser(NotificationCreateDto notificationCreateDto)
        {
            var token = _firestoreService.GetUserInfo(notificationCreateDto.Recipient.Id).Result.ToString();
            var settings = new RefitSettings(new NewtonsoftJsonContentSerializer());
            var fcmApi = RestService.For<INotificationApi>("https://fcm.googleapis.com", settings);
            NotificationItem notificationItem = new();
            notificationItem.to = token;
            notificationItem.notification = new Notification() { title = notificationCreateDto.Title, body = notificationCreateDto.Message };
            //key burada olmayacak
            fcmApi.NotifyUser(notificationItem, _fcm);
        }
    }
}
