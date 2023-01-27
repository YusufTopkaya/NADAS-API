using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Nadas.API.Business.Interfaces;
using Nadas.API.DTO.DTOs.NotificationDtos;
using Nadas.API.Entities.Concrete;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nadas.API.Business.Concrete
{
    public class NotificationManager :INotificationService
    {
        private readonly IFirestoreService _firestoreService;
        private readonly INotificationApi notificationApi;
        private readonly string _fcm;
        public NotificationManager(
            IFirestoreService firestoreService,
            IConfiguration configuration,
            INotificationApi notificationApi)
        {
            _firestoreService = firestoreService;
            this.notificationApi = notificationApi;
            _fcm = configuration.GetSection("fcmPrivateKey").Value;
        }

        public void NotifyUser(NotificationCreateDto notificationCreateDto)
        {
            var token = _firestoreService.GetUserInfo(notificationCreateDto.Recipient.Id).Result.ToString();
            NotificationItem notificationItem = new()
            {
                To = token,
                Notification = new Notification() { Title = notificationCreateDto.Title, Body = notificationCreateDto.Message }
            };
            notificationApi.NotifyUser(notificationItem, _fcm);
        }
    }
}
