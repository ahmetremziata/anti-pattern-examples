
using God_Object.Dto;

namespace God_Object.Business.Interfaces
{
    public interface IPaymentBusiness
    {
        void CreatePayment(Payment payment);
        void Pay(Payment payment, long userId, decimal amount, string fromCreditCardNumber);
        void Repay(Payment payment, long userId, decimal amount, string toCreditCardNumber);
    }
}