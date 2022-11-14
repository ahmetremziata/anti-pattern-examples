using System.Collections.Generic;
using God_Object.Dto;

namespace God_Object.Business.Interfaces
{
    public interface IOrderBusiness
    {
        void CreateOrder(Order order);
        Order GetOrder(long orderId);
        void UpdateOrder(long orderId);
        void DeleteOrder(long orderId);
        void AddItemsToOrder(long orderId, List<OrderItem> items);
        void RemoveItemsToOrder(long orderId, List<OrderItem> items);
        void Pay(long orderId, long userId, decimal amount, string fromCreditCardNumber);
        void Repay(long orderId, long userId, decimal amount, string toCreditCardNumber);
        void CancelOrder(long orderId);
        void ReturnOrder(long orderId);
        void SendOrderSucceededNotification(string payload);
        void SendOrderFailedNotification(string payload);
        void SendOrderCancelledNotification(string payload);
        void SendOrderReturnedNotification(string payload);
    }
}