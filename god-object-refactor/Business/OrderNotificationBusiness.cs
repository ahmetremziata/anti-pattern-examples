using System;
using System.Collections.Generic;
using System.Linq;
using God_Object.Business.Interfaces;
using God_Object.Dto;

namespace God_Object.Business
{
    public class OrderNotificationBusiness: IOrderNotificationBusiness
    {
        private readonly INotificationBusiness _notificationBusiness;
        
        public OrderNotificationBusiness(INotificationBusiness notificationBusiness)
        {
            _notificationBusiness = notificationBusiness;
        }
        
        public void SendOrderSucceededNotification(string payload)
        {
            _notificationBusiness.SendNotification("OrderSucceeded", "test@test.com", payload);
            Console.WriteLine("Call Send Order Succeeded Notification Function!");
        }

        public void SendOrderFailedNotification(string payload)
        {
            _notificationBusiness.SendNotification("OrderFailed", "test@test.com", payload);
            Console.WriteLine("Call Send Order Failed Notification Function!");
        }

        public void SendOrderCancelledNotification(string payload)
        {
            _notificationBusiness.SendNotification("OrderCancelled", "test@test.com", payload);
            Console.WriteLine("Call Send Order Cancelled Notification Function!");
        }

        public void SendOrderReturnedNotification(string payload)
        {
            _notificationBusiness.SendNotification("OrderReturned", "test@test.com", payload);
            Console.WriteLine("Call Send Order Returned Notification Function!");
        }
    }
}