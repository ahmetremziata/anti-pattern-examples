using System;
using System.Collections.Generic;
using God_Object.Business;
using God_Object.Business.Enums;
using God_Object.Business.Interfaces;
using God_Object.Dto;

namespace God_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderRepository orderRepository = new OrderRepository();
            IPaymentRepository paymentRepository = new PaymentRepository();
            IBankPosBusiness bankPosBusiness = new BankPosBusiness();
            INotificationBusiness notificationBusiness = new NotificationBusiness();
            IOrderBusiness orderBusiness = new OrderBusiness(orderRepository, paymentRepository, bankPosBusiness,
                notificationBusiness);

            Order order = new Order
            {
                OrderId = 1,
                UserId = 1000,
                TotalAmount = 0,
                FullName = "test testoğlu",
                Country = "Türkiye",
                City = "İstanbul",
                District = "Silivri",
                Address = "address",
                OrderStatusId = OrderStatus.Approved.GetHashCode(),
                PaymentStatusId = PaymentStatus.Created.GetHashCode(),
            };
            
            orderBusiness.CreateOrder(order);
            List<OrderItem> addedOrderItems = new List<OrderItem>
            {
                new()
                {
                    OrderItemId = 1,
                    Amount = 20,
                    ProductName = "Product1",
                    Quantity = 1,
                    Type = 1
                },
                new()
                {
                    OrderItemId = 2,
                    Amount = 10,
                    ProductName = "Product2",
                    Quantity = 2,
                    Type = 1
                }
            };
            orderBusiness.AddItemsToOrder(1, addedOrderItems);
            var foundOrder = orderRepository.GetOrder(1);
            orderBusiness.UpdateOrder(1);
            orderBusiness.Pay(foundOrder.OrderId, foundOrder.UserId, foundOrder.TotalAmount, "232323232323");
            orderBusiness.SendOrderSucceededNotification("Lorem Ipsum");
        }
    }
}
