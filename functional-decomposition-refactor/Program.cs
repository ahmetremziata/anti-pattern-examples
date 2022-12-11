using System;
using functional_decomposition_case.Dto;
using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started!");
            ICustomerRepository customerRepository = new CustomerRepository();
            ICustomer customerService = new Customer();
            var customer = customerRepository.GetCustomer("10408515600");

            if (customer == null)
            {
                customer = customerService.AddCustomer("10408515600", "George", "White");
            }

            customerService.ChangeCustomerAddress(customer, "Lorem Ipsum dolor sit amet");

            ILoanService loanService = new LoanService();
            var loanTotal = loanService.CalculateLoan(customer);
            var loadInterestTotal = loanService.CalculateInterest(customer, loanTotal);

            IPaymentSchedule paymentScheduleService = new PaymentScheduleService();
            paymentScheduleService.CalculatePaymentSchedule(customer);

            customerService.ChangeFinancialStatus(customer);
            
            Console.WriteLine(
                $"Customer load added for customer; {customer}, loanTotal:{loanTotal} loanInterestTotal:{loadInterestTotal}");
        }
    }
}