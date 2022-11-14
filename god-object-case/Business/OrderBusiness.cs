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
        private readonly IPaymentRepository _paymentRepository;
        private readonly IBankPosBusiness _bankPosBusiness;
        private readonly INotificationBusiness _notificationBusiness;
        
        public OrderBusiness(IOrderRepository orderRepository, 
            IPaymentRepository paymentRepository,
            IBankPosBusiness bankPosBusiness, 
            INotificationBusiness notificationBusiness)
        {
            _orderRepository = orderRepository;
            _paymentRepository = paymentRepository;
            _bankPosBusiness = bankPosBusiness;
            _notificationBusiness = notificationBusiness;
        }
        
        public void CreateOrder(Order order)
        {
            _orderRepository.CreateOrder(order);
            _paymentRepository.CreatePayment(order.Payment);
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

        public void Pay(long orderId, long userId, decimal amount, string fromCreditCardNumber)
        {
            var order = _orderRepository.GetOrder(orderId);
            _paymentRepository.CreatePayment(order.Payment);
            _bankPosBusiness.Pay(userId, amount, fromCreditCardNumber);
            Console.WriteLine("Call Pay Function!");
        }

        public void Repay(long orderId, long userId, decimal amount, string toCreditCardNumber)
        {
            var order = _orderRepository.GetOrder(orderId);
            _paymentRepository.UpdatePayment(order.Payment.PaymentId, order.Payment);
            _bankPosBusiness.Repay(userId, amount, toCreditCardNumber);
            Console.WriteLine("Call Repay Function!");
        }

        public void CancelOrder(long orderId)
        {
            Console.WriteLine("Call Cancel Order Function!");
        }

        public void ReturnOrder(long orderId)
        {
            Console.WriteLine("Call Return Order Function!");
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