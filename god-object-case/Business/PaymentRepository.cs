using System;
using God_Object.Business.Interfaces;
using God_Object.Dto;

namespace God_Object.Business
{
    public class PaymentRepository : IPaymentRepository
    {
        public void CreatePayment(Payment payment)
        {
            Console.WriteLine("Create payment on repository.");
        }

        public Payment GetPayment(long paymentId)
        {
            Console.WriteLine("Get payment on repository.");
            return new Payment();
        }

        public void UpdatePayment(long paymentId, Payment payment)
        {
            Console.WriteLine("Update payment on repository.");
        }
    }
}