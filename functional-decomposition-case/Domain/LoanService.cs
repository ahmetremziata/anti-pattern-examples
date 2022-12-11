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
    }
}