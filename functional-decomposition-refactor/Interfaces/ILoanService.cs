using functional_decomposition_case.Dto;

namespace functional_decomposition_case.Interfaces
{
    public interface ILoanService
    {
        double CalculateLoan(Customer customer);
        double CalculateInterest(Customer customer, double loan);
    }
}