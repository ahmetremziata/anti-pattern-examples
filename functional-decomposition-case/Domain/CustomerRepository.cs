using System;
using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(string identityNo)
        {
            return null;
        }

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added to db!");
        }
    }
}