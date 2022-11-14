using God_Object.Dto;

namespace God_Object.Business.Interfaces
{
    public interface IPaymentRepository
    {
        void CreatePayment(Payment payment);
        Payment GetPayment(long paymentId);
        void UpdatePayment(long paymentId, Payment payment);
    }
}