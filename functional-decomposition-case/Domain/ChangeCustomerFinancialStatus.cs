using System;
using functional_decomposition_case.Enums;
using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class ChangeCustomerFinancialStatus : IChangeCustomerFinancialStatus
    {
        public void ChangeFinancialStatus(Customer customer)
        {
            customer.StatusId = FinancialStatus.LoanCreated.GetHashCode();
	        Console.WriteLine("Customer financial status changed successfully! " + customer);
        }
    }
}