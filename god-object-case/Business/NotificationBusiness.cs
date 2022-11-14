using System;
using God_Object.Business.Interfaces;

namespace God_Object.Business
{
    public class NotificationBusiness : INotificationBusiness
    {
        public void SendNotification(string template, string to, string payload)
        {
            Console.WriteLine("Do something for notification and send notification.");
        }
    }
}