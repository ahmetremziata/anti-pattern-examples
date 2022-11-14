using System.Collections.Generic;

namespace God_Object.Dto
{
    public class Order
    {
        public long OrderId { get; set; }
        public long UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int OrderStatusId { get; set; }
        public int PaymentStatusId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Payment Payment { get; set; }
    }
}