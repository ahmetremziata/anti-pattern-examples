using God_Object.Dto;

namespace God_Object.Business.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        Order GetOrder(long orderId);
        void UpdateOrder(long orderId, Order order);
        void DeleteOrder(long orderId);
        void CancelOrder(long orderId);
        void ReturnOrder(long orderId);
    }
}