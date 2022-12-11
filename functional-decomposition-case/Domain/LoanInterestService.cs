using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class LoanInterestService: ILoanInterestService
    {
        public double CalculateInterest(Customer customer, double loan)
        {
            if (customer.IsElite)
            {
                return loan * 0.1;
            }

            return loan * 0.2;
        }
    }
}