using System;
using God_Object.Business.Interfaces;
using God_Object.Dto;

namespace God_Object.Business
{
    public class OrderRepository : IOrderRepository
    {
        public void CreateOrder(Order order)
        {
            Console.WriteLine("Create order on repository.");
        }
        
        public Order GetOrder(long orderId)
        {
            Console.WriteLine("Get order on repository.");
            return new Order();
        }

        public void UpdateOrder(long orderId, Order order)
        {
            Console.WriteLine("Update order on repository.");
        }

        public void DeleteOrder(long orderId)
        {
            Console.WriteLine("Delete order on repository.");
        }

        public void CancelOrder(long orderId)
        {
            Console.WriteLine("Cancel order on repository.");
        }

        public void ReturnOrder(long orderId)
        {
            Console.WriteLine("Return order on repository.");
        }
    }
}