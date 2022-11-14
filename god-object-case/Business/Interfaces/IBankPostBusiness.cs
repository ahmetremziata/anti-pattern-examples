namespace God_Object.Business.Interfaces
{
    public interface IBankPosBusiness
    {
        void Pay(long userId, decimal amount, string fromCreditCardNumber);
        void Repay(long userId, decimal amount, string toCreditCardNumber);
    }
}