using System;
using God_Object.Business.Interfaces;

namespace God_Object.Business
{
    public class BankPosBusiness : IBankPosBusiness
    {
        public void Pay(long userId, decimal amount, string fromCreditCardNumber)
        {
            Console.WriteLine("Connect banks and pay them");
        }

        public void Repay(long userId, decimal amount, string toCreditCardNumber)
        {
            Console.WriteLine("Connect banks and repay them");
        }
    }
}