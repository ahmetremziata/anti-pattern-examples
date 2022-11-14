using System;
using God_Object.Business.Interfaces;
using God_Object.Dto;

namespace God_Object.Business
{
    public class PaymentBusiness: IPaymentBusiness
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IBankPosBusiness _bankPosBusiness;
        
        public PaymentBusiness(
            IPaymentRepository paymentRepository,
            IBankPosBusiness bankPosBusiness)
        {
            _paymentRepository = paymentRepository;
            _bankPosBusiness = bankPosBusiness;
        }

        public void CreatePayment(Payment payment)
        {
            _paymentRepository.CreatePayment(payment);
            Console.WriteLine("Call Create Payment Function!");
        }

        public void Pay(Payment payment, long userId, decimal amount, string fromCreditCardNumber)
        {
            _paymentRepository.CreatePayment(payment);
            _bankPosBusiness.Pay(userId, amount, fromCreditCardNumber);
            Console.WriteLine("Call Pay Function!");
        }

        public void Repay(Payment payment, long userId, decimal amount, string toCreditCardNumber)
        {
            _paymentRepository.UpdatePayment(payment.PaymentId, payment);
            _bankPosBusiness.Repay(userId, amount, toCreditCardNumber);
            Console.WriteLine("Call Repay Function!");
        }
    }
}