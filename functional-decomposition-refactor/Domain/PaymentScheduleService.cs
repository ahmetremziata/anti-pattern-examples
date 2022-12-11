using System;
using functional_decomposition_case.Interfaces;

namespace functional_decomposition_case.Dto
{
    public class PaymentScheduleService : IPaymentSchedule
    {
        public void CalculatePaymentSchedule(Customer customer)
        {
            Console.WriteLine("Calculate payment schedule! " + customer);
        }
        
        public void AlterPaymentSchedule(Customer customer)
        {
            Console.WriteLine("Changing payment schedule to specific customer " + customer);
        }
    }
}