using System.Collections.Generic;
using God_Object.Dto;

namespace God_Object.Business.Interfaces
{
    public interface IOrderNotificationBusiness
    {
        void SendOrderSucceededNotification(string payload);
        void SendOrderFailedNotification(string payload);
        void SendOrderCancelledNotification(string payload);
        void SendOrderReturnedNotification(string payload);
    }
}