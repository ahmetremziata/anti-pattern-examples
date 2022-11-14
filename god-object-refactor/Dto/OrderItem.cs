namespace God_Object.Dto
{
    public class OrderItem
    {
        public long OrderItemId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Type { get; set; }
        public decimal Amount { get; set; }
    }
}