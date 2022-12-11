using System;
using functional_decomposition_case.Enums;
using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class Customer: ICustomer
    {
        private string IdentityNo { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        public int StatusId { get; set; }

        public bool IsElite { get; set; }
        public string Address { get; set; }
        
        public Customer AddCustomer(string identityNo, string name, string surname)
        {
            var customer = new Customer
            {
                IdentityNo = identityNo,
                Name = name,
                Surname = surname,
                StatusId = FinancialStatus.NotSet.GetHashCode(),
            };
            return customer;
        }

        public void ChangeCustomerAddress(Customer customer, string address)
        {
            customer.Address = address;
            Console.WriteLine("Customer address changed successfully! " + customer);
        }

        public void ChangeFinancialStatus(Customer customer)
        {
            customer.StatusId = FinancialStatus.LoanCreated.GetHashCode();
            Console.WriteLine("Customer financial status changed successfully! " + customer);

        }

        public override string ToString()
        {
            return $"IdentityNo:{IdentityNo} Name:{Name} Surname:{Surname}";
        }
    }
}