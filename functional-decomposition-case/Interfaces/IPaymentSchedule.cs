using functional_decomposition_case.Dto;

namespace functional_decomposition_case.Interfaces
{
    public interface IPaymentSchedule
    {
        void CalculatePaymentSchedule(Customer customer);
    }
}