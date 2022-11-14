namespace God_Object.Dto
{
    public class Payment
    {
        public long PaymentId { get; set; }
        public decimal Amount { get; set; }
        public int BankId { get; set; }
        public bool IsSuccess { get; set; }
        public string CreditCardNumber { get; set; }
    }
}