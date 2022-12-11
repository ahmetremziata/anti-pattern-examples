using functional_decomposition_case.Dto;

namespace functional_decomposition_case.Interfaces
{
    public interface ILoanInterestService
    {
        double CalculateInterest(Customer customer, double loan);
    }
}