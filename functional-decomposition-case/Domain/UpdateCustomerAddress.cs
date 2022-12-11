using System;
using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class UpdateCustomerAddress: IUpdateCustomerAddress
    {
        public void ChangeCustomerAddress(Customer customer, string address)
        {
            customer.Address = address;
            Console.WriteLine("Customer address changed successfully! " + customer);
        }
    }
}