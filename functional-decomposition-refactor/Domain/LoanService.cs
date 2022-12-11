using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class LoanService : ILoanService
    {
        public double CalculateLoan(Customer customer)
        {
            if (customer.IsElite)
            {
                //some calculations
                return 100;
            }

            return 50;
        }
        
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