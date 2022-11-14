using System;
using System.Collections.Generic;
using System.Linq;
using God_Object.Business.Interfaces;
using God_Object.Dto;

namespace God_Object.Business
{
    public class OrderBusiness: IOrderBusiness
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IPaymentBusiness _paymentBusiness;
        
        public OrderBusiness(IOrderRepository orderRepository, 
            IPaymentBusiness paymentBusiness)
        {
            _orderRepository = orderRepository;
            _paymentBusiness = paymentBusiness;
        }
        
        public void CreateOrder(Order order)
        {
            _orderRepository.CreateOrder(order);
            _paymentBusiness.CreatePayment(order.Payment);
            Console.WriteLine("Call Create Order Function!");
        }

        public Order GetOrder(long orderId)
        {
            Console.WriteLine("Call Get Order Function!");
            return _orderRepository.GetOrder(orderId);
        }
        
        public void UpdateOrder(long orderId)
        {
            _orderRepository.UpdateOrder(orderId, new Order());
            Console.WriteLine("Call Update Order Function!");
        }

        public void DeleteOrder(long orderId)
        {
            _orderRepository.DeleteOrder(orderId);
            Console.WriteLine("Call Delete Order Function!");
        }

        public void AddItemsToOrder(long orderId, List<OrderItem> items)
        {
            var order = _orderRepository.GetOrder(orderId);
            order.OrderItems = items;
            _orderRepository.UpdateOrder(orderId, order);
            Console.WriteLine("Call Add Items To Order Function!");
        }

        public void RemoveItemsToOrder(long orderId, List<OrderItem> items)
        {
            var order = _orderRepository.GetOrder(orderId);
            order.OrderItems = order.OrderItems.Except(items).ToList();
            _orderRepository.UpdateOrder(orderId, order);
            Console.WriteLine("Call Remove Items To Order Function!");
        }

        public void CancelOrder(long orderId)
        {
            Console.WriteLine("Call Cancel Order Function!");
        }

        public void ReturnOrder(long orderId)
        {
            Console.WriteLine("Call Return Order Function!");
        }
    }
}